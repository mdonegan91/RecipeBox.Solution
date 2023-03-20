using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Tag
    {
        public int TagId { get; set; }
        [Required(ErrorMessage = "The recipe's cuisine field can't be left empty!")]
        public string Cuisine { get; set; }
        public List<RecipeTag> JoinEntities { get;}
        public ApplicationUser User { get; set; } 
    }
}