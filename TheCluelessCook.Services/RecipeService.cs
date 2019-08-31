using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheCluelessCook.Data;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Services
{
    public class RecipeService : IRecipe
    {
        // This is done in order for the service to be able to
        // interact with the database
        private readonly ApplicationDbContext _context;

        public RecipeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
        }

        public Task DeleteRecipe(int recipeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _context.Recipes;
        }

        public Recipe GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
