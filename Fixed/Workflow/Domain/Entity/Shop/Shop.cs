using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Fixed.Workflow.Domain.Entity.Shop
{
    public class Shop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public ICollection<Order.Order> Orders { get; set; }

        public IEnumerable<Order.Order> GetOrdersFromWorkday(Workday.Workday workday) => from o in Orders
            where o.Workday.Equals(workday) 
            select o;
    }
}
