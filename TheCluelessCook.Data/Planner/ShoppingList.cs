using System;
using System.Collections.Generic;
using TheCluelessCook.Data.Models;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Data.Planner
{
    public class ShoppingList
    {
        public int Id { get; set; }

        public string ListName { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual IEnumerable<RecipeIngredient> Ingredients { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
