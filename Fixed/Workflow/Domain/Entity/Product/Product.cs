using System;
using System.ComponentModel.DataAnnotations;

namespace Fixed.Workflow.Domain.Entity.Product
{
    public class Product
    {
        [Key]
        public Guid Guid { get; set; }
        public string Name { get; set; }
    }
}
