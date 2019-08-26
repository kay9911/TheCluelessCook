using System;
using System.Collections.Generic;
using TheCluelessCook.Data.Models;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Data.Planner
{
    public class DayPlan
    {
        public int Id { get; set; }

        public string DayOfTheWeek { get; set; }

        public DateTime CreatedFor { get; set; }

        //public virtual IEnumerable<Recipe> Breakfast { get; set; }
        //public virtual IEnumerable<Recipe> Lunch { get; set; }
        //public virtual IEnumerable<Recipe> Dinner { get; set; }

        public ApplicationUser User { get; set; }
    }
}
