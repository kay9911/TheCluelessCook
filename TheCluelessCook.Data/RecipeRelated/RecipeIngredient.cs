namespace TheCluelessCook.Data.RecipeRelated
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string Name { get; set; }
        public string Action { get; set; }

        // Navigation / FK
        public virtual Recipe Recipe { get; set; }
    }
}
