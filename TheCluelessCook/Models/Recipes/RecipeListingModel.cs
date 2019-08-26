namespace TheCluelessCook.Models.Recipes
{
    public class RecipeListingModel
    {
        public int Id { get; set; }
        public int Complexity { get; set; }
        public int Rating { get; set; }

        public bool PrepRequired { get; set; }

        public string Name { get; set; }
        public string TimeRequired { get; set; }
        public string ServingSuggestion { get; set; }
    }
}
