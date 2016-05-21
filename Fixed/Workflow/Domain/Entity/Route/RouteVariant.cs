using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fixed.Workflow.Domain.Entity.Route
{
    public class RouteVariant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }
        public Route Route { get; set; }
        public ICollection<Workday.Workday> Workdays { get; set; }
        public ICollection<Shop.Shop> Shops { get; set; } 
    }
}
