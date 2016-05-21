using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Fixed.Workflow.Domain.Entity.Route;

namespace Fixed.Workflow.Domain.Entity.Workday
{
    public class Workday
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public ICollection<RouteVariant> RouteVariants { get; set; }
        public ICollection<Order.Order> Orders { get; set; } 
    }
}
