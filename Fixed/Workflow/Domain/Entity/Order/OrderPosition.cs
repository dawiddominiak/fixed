using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fixed.Workflow.Domain.Entity.Order
{
    public class OrderPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public Product.Product Product { get; set; }
        public Entity.Order.Order Order { get; set; }
        public int NumberOfProducts { get; set; }
    }
}
