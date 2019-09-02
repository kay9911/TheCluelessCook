using System.Collections.Generic;

namespace TheCluelessCook.Models.Planner
{
    public class MealPlannerIndexModel
    {
        // This will build the accordian
        public IEnumerable<WeeklyPlanAccordianModel> days { get; set; }

        // Data that goes into the accordian
        public IEnumerable<DayDetailModel> details { get; set; }
    }
}
