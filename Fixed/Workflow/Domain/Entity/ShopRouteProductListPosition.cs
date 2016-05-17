using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixed.Workflow.Domain.Entity
{
    public class ShopRouteProductListPosition
    {
        [Key]
        public Guid Guid { get; set; }
        public Shop Shop { get; set; }
        public Route Route { get; set; }
        public Product Product { get; set; }
        public int NumberOfProducts { get; set; }
    }
}
