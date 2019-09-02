using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Models.Planner
{
    public class DayDetailModel
    {
        public int Id { get; set; }
        // Name of day --> ex : Sunday, Monday, Tuesday
        public string Day { get; set; }
        // Day Date --> ex : 1,2,3,4,5
        public string Date { get; set; }
        // User set best time to eat
        public string UserBestTime { get; set; }

        // Recipe Details
        public Recipe recipe  { get; set; }
    }
}
