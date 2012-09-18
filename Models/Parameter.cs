using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class Parameter : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public Guid BlockId { get; set; }
        
        [Required]
        public Guid SubCategoryId { get; set; }
        
        [Required]
        public string Type { get; set; }

        public virtual Block Block { get; set; }
        
        public virtual SubCategory SubCategory { get; set; }
    }
}