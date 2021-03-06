﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class Item : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public Guid ValueId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Value> Values { get; set; } 

    }
}