namespace OurRecipes.Data.Models
{
    using OurRecipes.Data.Common.Models;

    public class RecipeIngredient : BaseModel<int>
    {
        public Recipe Recipe { get; set; }

        public Ingredient Ingredient { get; set; }

        public string Quantity { get; set; }
    }
}
