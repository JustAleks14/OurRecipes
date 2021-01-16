namespace OurRecipes.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Data.Models;
    using OurRecipes.Services.Data;
    using OurRecipes.Web.ViewModels;
    using OurRecipes.Web.ViewModels.Recipes;

    public class RecipesController : BaseController
    {
        private readonly IRecipesService recipesService;
        private UserManager<ApplicationUser> userManager;

        public RecipesController(IRecipesService recipesService, UserManager<ApplicationUser> userManager)
        {
            this.recipesService = recipesService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult CreateRecipe()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe(RecipeInputModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            await this.recipesService.CreateAsync(input, user);
            return this.View();
        }

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
        }
    }
}
