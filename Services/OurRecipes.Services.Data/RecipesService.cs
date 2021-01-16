namespace OurRecipes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using OurRecipes.Data.Common.Repositories;
    using OurRecipes.Data.Models;
    using OurRecipes.Services.Mapping;

    public class RecipesService : IRecipesService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;

        public RecipesService(IDeletableEntityRepository<Recipe> recipesRepository)
        {
            this.recipesRepository = recipesRepository;
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var recipes = this.recipesRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>()
                .ToList();
            return recipes;
        }

        public int GetCount()
        {
            return this.recipesRepository.All().Count();
        }
    }
}
