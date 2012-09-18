using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class Value : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]    
        public Guid ParameterId { get; set; }
        
        [Required]
        public Guid ItemId { get; set; }
        
        [MaxLength(150)]
        public string TextValue { get; set; }

        public bool BoolValue { get; set; }

        public virtual Item Item { get; set; }

        public virtual Parameter Parameter { get; set; }
    }
}