using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity.Route
{
    public class Route
    {
        [Key]
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public ICollection<RouteVariant> Variants { get; set; } 
    }
}
