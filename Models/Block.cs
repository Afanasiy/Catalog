using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class Block
    {
        [Key]
        public Guid BlockId { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Parameter> Parameters { get; set; } 
    }
}