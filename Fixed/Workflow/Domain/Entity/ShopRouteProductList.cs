using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixed.Workflow.Domain.Entity
{
    public class ShopRouteProductList
    {
        [Key]
        public Guid Guid { get; set; }
        public Workday Workday { get; set; }
        public ICollection<ShopRouteProductListPosition> ShopProductListPositions { get; set; } 
    }
}
