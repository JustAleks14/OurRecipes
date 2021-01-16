namespace OurRecipes.Data.Models
{
    using OurRecipes.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
