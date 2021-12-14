using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityBuilding.Models
{
    [DisplayName("Category")]
    public class Category
    {
        [Key]
        public string Name { get; set; }
        
        [Required]
        [StringLength(150, ErrorMessage = "Name length can't be more than 150 characters.")]
        public string Description { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}