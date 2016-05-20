using System;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity.Order
{
    public class OrderPosition
    {
        [Key]
        public Guid Guid { get; set; }
        public Product.Product Product { get; set; }
        public Entity.Order.Order Order { get; set; }
        public int NumberOfProducts { get; set; }
    }
}
