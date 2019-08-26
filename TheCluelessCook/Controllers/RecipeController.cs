using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TheCluelessCook.Data;
using TheCluelessCook.Models.Recipes;

namespace TheCluelessCook.Controllers
{
    public class RecipeController : Controller
    {
        // This is to signal that we are to recieve a concrete class of service
        // everytime a particular Interface is implemeted
        private readonly IRecipe _recipeService;

        public RecipeController(IRecipe recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            var recipeList = _recipeService.GetAll()
                .Select(recipe => new RecipeListingModel
                {
                    // Map details from EF class to ViewModelClass
                    Id = recipe.Id,
                    Complexity = recipe.Complexity,
                    Rating = recipe.Rating,
                    PrepRequired = recipe.PrepRequired,
                    Name = recipe.Name,
                    TimeRequired = recipe.TimeRequired,
                    ServingSuggestion = recipe.ServingSuggestion
                });

            var model = new RecipeIndexModel
            {
                Recipes = recipeList
            };

            return View(model);
        }
    }
}