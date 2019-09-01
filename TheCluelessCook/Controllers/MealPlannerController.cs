using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCluelessCook.Data;
using TheCluelessCook.Models.Planner;

namespace TheCluelessCook.Controllers
{
    public class MealPlannerController : Controller
    {
        private readonly IRecipe _recipeService;

        public MealPlannerController(IRecipe recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            // Build out the week section section
            DateTime _today = DateTime.Now;
            int _currentDay = (int)_today.DayOfWeek;

            // Get the list of days
            var _WeekDetails = Enumerable.Range(0, 7)
                .Select(Days => new DayDetailModel
                {
                    Id = _today.AddDays(Days).ToString(),
                    Date = _today.AddDays(Days).Day.ToString(),
                    Day = _today.AddDays(Days).DayOfWeek.ToString()
                }).ToList();

            var DaysofthisWeek = new MealPlannerIndexModel
            {
                days = _WeekDetails
            };

            return View(DaysofthisWeek);
        }

        public IActionResult Plan()
        {
            return View();
        }
    }
}