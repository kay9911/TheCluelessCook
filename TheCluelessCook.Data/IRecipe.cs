using System.Collections.Generic;
using System.Threading.Tasks;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Data
{
    public interface IRecipe
    {
        Recipe GetById(int Id);
        IEnumerable<Recipe> GetAll();

        Task CreateRecipe(Recipe recipe);
        Task DeleteRecipe(int recipeId);
        Task UpdateRecipe(Recipe recipe);
    }
}
