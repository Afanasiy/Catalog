using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class SubCategory
    {
        [Key]
        public Guid SubCategoryId { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual Category Category { get; set; }

    }
}