using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using Fixed.Workflow.Domain.Entity.Order;
using Fixed.Workflow.Domain.Entity.Product;
using Fixed.Workflow.Domain.Entity.Route;
using Fixed.Workflow.Domain.Entity.Shop;
using Fixed.Workflow.Domain.Entity.Workday;

namespace Fixed.Workflow.Domain
{
    public class WorkflowContext : DbContext
    {
        public DbSet<Workday> Workdays { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteVariant> RouteVariants { get; set; } 
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderPosition> OrderPositions { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TODO: remove on production
            Database.SetInitializer<WorkflowContext>(new DropCreateDatabaseIfModelChanges<WorkflowContext>());

            modelBuilder.Entity<Workday>()
                .HasMany(w => w.RouteVariants)
                .WithMany(v => v.Workdays)
                .Map(
                    wv =>
                    {
                        wv.MapLeftKey("WorkdayReferenceId");
                        wv.MapRightKey("RouteVariantReferenceId");
                        wv.ToTable("WorkdayRouteVariant");
                    }
                )
            ;

            modelBuilder.Entity<Workday>()
                .HasMany(w => w.Orders)
                .WithRequired(o => o.Workday)
                .HasForeignKey(o => o.WorkdayId)
            ;

            modelBuilder.Entity<Route>()
                .HasMany(r => r.Variants)
                .WithRequired(v => v.Route)
            ;

            modelBuilder.Entity<RouteVariant>()
                .HasMany(v => v.Shops)
                .WithMany()
                .Map(
                    vs =>
                    {
                        vs.MapLeftKey("RouteVariantReferenceId");
                        vs.MapRightKey("ShopReferenceId");
                        vs.ToTable("RouteVariantsShops");
                    }
                )
            ;

            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Orders)
                .WithRequired(o => o.Shop)
                .HasForeignKey(o => o.ShopId)
            ;

            modelBuilder.Entity<Order>()
                .Property(o => o.WorkdayId)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IDX_WorkdayShop", 1) {IsUnique = true}
                    )
                )
            ;

            modelBuilder.Entity<Order>()
                .Property(o => o.ShopId)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IDX_WorkdayShop", 2) {IsUnique = true}
                        )
                )
            ;

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderPositions)
                .WithRequired(op => op.Order)
            ;

            modelBuilder.Entity<OrderPosition>()
                .HasRequired(op => op.Product)
                .WithMany()
            ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
