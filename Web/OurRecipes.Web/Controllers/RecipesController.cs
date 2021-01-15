namespace OurRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Web.ViewModels;

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
    }
}
