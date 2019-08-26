namespace TheCluelessCook.Data.RecipeRelated
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public int StepNo { get; set; }

        public bool StepPrepRequired { get; set; }

        public string StepDescription { get; set; }

        // Navigation / FK
        public virtual Recipe Recipe { get; set; }
    }
}
