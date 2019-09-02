using TheCluelessCook.Data.Models;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Data.Planner
{
    public class DayPlan
    {
        public int Id { get; set; }

        // Name of day --> ex : Sunday, Monday, Tuesday
        public string Day { get; set; }
        // Day Date --> ex : 1,2,3,4,5
        public string Date { get; set; }

        // Recipe Details
        public virtual Recipe Recipe { get; set; }

        // Uniue Id of User --> Identity Table UserId
        public ApplicationUser UserId { get; set; }
    }
}
