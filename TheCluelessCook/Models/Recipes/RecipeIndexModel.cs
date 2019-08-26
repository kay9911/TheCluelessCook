using System.Collections.Generic;

namespace TheCluelessCook.Models.Recipes
{
    public class RecipeIndexModel
    {
        public IEnumerable<RecipeListingModel> Recipes { get; set; }
    }
}
