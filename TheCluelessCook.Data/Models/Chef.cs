using System;
using System.Collections.Generic;
using TheCluelessCook.Data.Planner;

namespace TheCluelessCook.Data.Models
{
    public class Chef
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual IEnumerable<DayPlan> TheWeeksPlan { get; set; }
        public virtual IEnumerable<ShoppingList> ShoppingLists { get; set; }
    }
}
