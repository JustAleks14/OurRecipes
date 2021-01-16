namespace OurRecipes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using OurRecipes.Web.ViewModels.Recipes;

    public interface IRecipesService
    {
        Task CreateAsync(RecipeInputModel input, string userId);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();
    }
}
