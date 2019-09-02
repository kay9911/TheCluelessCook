using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheCluelessCook.Data.Models;
using TheCluelessCook.Data.Planner;
using TheCluelessCook.Data.RecipeRelated;

namespace TheCluelessCook.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Recipe Related DataTables
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }

        // Model DataTables
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<Chef> Chefs { get; set; }

        // Planner DataTables
        public DbSet<DayPlan> DayPlans { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
