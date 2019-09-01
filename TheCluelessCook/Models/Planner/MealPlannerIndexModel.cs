using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheCluelessCook.Models.Planner
{
    public class MealPlannerIndexModel
    {
        public IEnumerable<DayDetailModel> days { get; set; }
    }
}
