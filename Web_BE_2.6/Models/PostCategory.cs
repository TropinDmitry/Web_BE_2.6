﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BE_6.Models
{
    public class PostCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(200)]
        public String Name { get; set; }
    }
}
