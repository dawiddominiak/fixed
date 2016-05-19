using System;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity
{
    public class Workday
    {
        [Key]
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public ShopRouteProductList ShopRouteProductList { get; set; }
    }
}
