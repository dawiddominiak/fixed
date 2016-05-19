using System.Data.Entity;
using Fixed.Workflow.Domain.Entity;

namespace Fixed.Workflow.Domain
{
    public class WorkflowContext : DbContext
    {
        public DbSet<Workday> Workdays { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Route> Routes { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopRouteProductList> ShopRouteProductLists { get; set; }
        public DbSet<ShopRouteProductListPosition> ShopRouteProductListPositions { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workday>()
                .HasRequired(t => t.ShopRouteProductList)
                .WithRequiredPrincipal(t => t.Workday)
            ;

            modelBuilder.Entity<ShopRouteProductList>()
                .HasMany(t => t.ShopProductListPositions)
            ;

            modelBuilder.Entity<ShopRouteProductListPosition>()
                .HasRequired(t => t.Product)
            ;

            modelBuilder.Entity<ShopRouteProductListPosition>()
                .HasRequired(t => t.Route)
            ;

            modelBuilder.Entity<ShopRouteProductListPosition>()
                .HasRequired(t => t.Shop)
            ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
