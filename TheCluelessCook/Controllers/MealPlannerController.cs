using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheCluelessCook.Data;
using TheCluelessCook.Data.Models;
using TheCluelessCook.Models.Planner;

namespace TheCluelessCook.Controllers
{
    public class MealPlannerController : Controller
    {
        private readonly IRecipe _recipeService;
        private readonly IPlanner _plannerService;
        private readonly UserManager<ApplicationUser> _userManager;

        public MealPlannerController(IRecipe recipeService, IPlanner plannerService, UserManager<ApplicationUser> userManager)
        {
            _recipeService = recipeService;
            _plannerService = plannerService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // Load in the recipe details for each day of the week
            // Get the user id
            var _curUser = _userManager.GetUserId(User);
            // Pass User Id in order to get list of week details
            var _weekDetails = _plannerService.GetByUser(_curUser)
                .Select(detail => new DayDetailModel
                {
                    Id = detail.Id,
                    Date = detail.Date,
                    Day = detail.Day,
                    recipe = detail.Recipe,
                    UserBestTime = detail.UserBestEatenAt
                });

            var model = new MealPlannerIndexModel
            {
                days = GetCurrentWeek(),
                details = _weekDetails
            };

            return View(model);
        }

        public IActionResult Plan()
        {
            return View();
        }

        private IEnumerable<WeeklyPlanAccordianModel> GetCurrentWeek()
        {
            // Build out the week section section
            DateTime _today = DateTime.Now;
            int _currentDay = (int)_today.DayOfWeek;

            // Get the list of days
            var _WeekDetails = Enumerable.Range(0, 7)
                .Select(Days => new WeeklyPlanAccordianModel
                {
                    Id = _today.AddDays(Days).ToString(),
                    Date = _today.AddDays(Days).Day.ToString(),
                    Day = _today.AddDays(Days).DayOfWeek.ToString()
                }).ToList();

            return _WeekDetails;
        }
    }
}