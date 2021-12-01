﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipesEShop.Models
{
    public class Ingredient
    {

        [Key]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }
    }
}