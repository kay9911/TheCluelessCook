using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCluelessCook.Data;
using TheCluelessCook.Data.Planner;

namespace TheCluelessCook.Services
{
    public class PlannerService : IPlanner
    {
        private readonly ApplicationDbContext _context;

        public PlannerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateDayPlanningItem(DayPlan dayPlan)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDayPlanningItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DayPlan> GetByDate(string Date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DayPlan> GetByDay(string Day)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DayPlan> GetByUser(string UserId)
        {
            var _DayPlans = _context.DayPlans
                .Where(dayplan => dayplan.UserId.Id == UserId)
                .Include(x => x.Recipe);    // Load Recipes as well

            return _DayPlans;
        }

        public Task UpdateDayPlanningItem(DayPlan dayPlan)
        {
            throw new NotImplementedException();
        }
    }
}
