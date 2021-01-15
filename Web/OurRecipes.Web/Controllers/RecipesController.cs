namespace OurRecipes.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using OurRecipes.Data.Common.Repositories;
    using OurRecipes.Data.Models;
    using OurRecipes.Web.ViewModels;

    public class RecipesController : BaseController
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AllRecipes()
        {
            return this.View();
        }
    }
}
