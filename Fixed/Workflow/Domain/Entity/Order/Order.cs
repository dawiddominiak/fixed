using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity.Order
{
    public class Order
    {
        [Key]
        public Guid Guid { get; set; }
        public Shop.Shop Shop { get; set; }
        public Guid ShopId { get; set; }
        public Workday.Workday Workday { get; set; }
        public Guid WorkdayId { get; set; }
        public ICollection<OrderPosition> OrderPositions { get; set; } 
    }
}
