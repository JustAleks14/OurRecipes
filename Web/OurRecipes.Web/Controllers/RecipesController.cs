namespace OurRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Web.ViewModels;
    using OurRecipes.Web.ViewModels.Recipes;

    public class RecipesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult CreateRecipe()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult CreateRecipe(RecipeInputModel input)
        {
            return this.View();
        }
    }
}
