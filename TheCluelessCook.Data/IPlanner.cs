using System.Collections.Generic;
using System.Threading.Tasks;
using TheCluelessCook.Data.Planner;

namespace TheCluelessCook.Data
{
    public interface IPlanner
    {
        // List Returns Only
        IEnumerable<DayPlan> GetByDay(string Day);
        IEnumerable<DayPlan> GetByDate(string Date);
        IEnumerable<DayPlan> GetByUser(string UserId);

        // CRUD
        Task CreateDayPlanningItem(DayPlan dayPlan);
        Task UpdateDayPlanningItem(DayPlan dayPlan);
        Task DeleteDayPlanningItem(int id);
    }
}
