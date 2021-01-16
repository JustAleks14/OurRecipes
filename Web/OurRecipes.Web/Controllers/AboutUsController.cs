namespace OurRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Services.Data;
    using OurRecipes.Web.ViewModels;
    using OurRecipes.Web.ViewModels.Recipes;

    public class AboutUsController : BaseController
    {
        private readonly IRecipesService recipesService;

        public AboutUsController(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        public IActionResult Index()
        {
            var viewModel = new RecipesListViewModel
            {
                RecipesCount = this.recipesService.GetCount(),
            };
            return this.View(viewModel);
        }
    }
}
