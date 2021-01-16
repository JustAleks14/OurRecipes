namespace OurRecipes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using OurRecipes.Data.Models;
    using OurRecipes.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        RecipeInfoViewModel GetRecipeInfo(int id);

        Task CreateAsync(RecipeInputModel input, ApplicationUser user);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        List<AllRecipesViewModel> GetAll(int recipesCount);

        int GetCount();
    }
}
