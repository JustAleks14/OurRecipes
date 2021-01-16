namespace OurRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Services.Data;
    using OurRecipes.Web.ViewModels;
    using OurRecipes.Web.ViewModels.Recipes;

    public class RecipesController : BaseController
    {
        private readonly IRecipesService recipesService;

        public RecipesController(IRecipesService recipesService)
        {
            this.recipesService = recipesService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult CreateRecipe()
        {
            return this.View();
        }

<<<<<<< HEAD
        [HttpPost]
        public IActionResult CreateRecipe(RecipeInputModel input)
        {
            return this.View();
=======
        public IActionResult AllRecipes(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 12;
            var viewModel = new RecipesListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                RecipesCount = this.recipesService.GetCount(),
                Recipes = this.recipesService.GetAll<AllRecipesViewModel>(id, ItemsPerPage),
            };
            return this.View(viewModel);
>>>>>>> 7920a3eae0466c1689951c8b412816d5cec9768c
        }
    }
}
