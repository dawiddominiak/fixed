using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity.Route
{
    public class RouteVariant
    {
        [Key]
        public Guid Guid { get; set; }
        public Entity.Route.Route Route { get; set; }
        public ICollection<Workday.Workday> Workdays { get; set; }
        public ICollection<Shop.Shop> Shops { get; set; } 
    }
}
