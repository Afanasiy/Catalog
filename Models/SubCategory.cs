﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalog.Models
{
    public class SubCategory : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Parameter> Parameters { get; set; } 

    }
}