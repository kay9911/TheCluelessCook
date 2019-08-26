using System;
using System.Collections.Generic;
using TheCluelessCook.Data.Models;

namespace TheCluelessCook.Data.RecipeRelated
{
    public class Recipe
    {
        public int Id { get; set; }
        public int Complexity { get; set; }
        public int Rating { get; set; }

        public bool PrepRequired { get; set; }

        public string Name { get; set; }
        public string TimeRequired { get; set; }
        public string ImageURL { get; set; }
        public string ServingSuggestion { get; set; }

        public DateTime TimeCreated { get; set; }

        public virtual IEnumerable<RecipeStep> RecipeSteps { get; set; }
        public virtual IEnumerable<RecipeIngredient> RecipeIngredients { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
    }
}
