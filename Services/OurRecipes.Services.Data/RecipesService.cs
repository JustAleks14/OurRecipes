﻿namespace OurRecipes.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OurRecipes.Data.Common.Repositories;
    using OurRecipes.Data.Models;
    using OurRecipes.Services.Mapping;
    using OurRecipes.Web.ViewModels.Recipes;

    public class RecipesService : IRecipesService
    {
        private readonly IDeletableEntityRepository<Recipe> recipesRepository;
        private readonly IDeletableEntityRepository<Ingredient> ingredientsRespository;
        private readonly IDeletableEntityRepository<Step> stepsRespository;

        public RecipesService(
            IDeletableEntityRepository<Recipe> recipesRepository,
            IDeletableEntityRepository<Ingredient> ingredientsRespository,
            IDeletableEntityRepository<Step> stepsRespository)
        {
            this.recipesRepository = recipesRepository;
            this.ingredientsRespository = ingredientsRespository;
            this.stepsRespository = stepsRespository;
        }

        public async Task CreateAsync(RecipeInputModel input, string userId)
        {
            TimeSpan ts = new TimeSpan(input.Time);
            var recipe = new Recipe
            {
                Name = input.Name,
                MealCount = input.MealCount,
                Image = input.Image,
                DifficultyLevel = input.DifficultyLevel,
                Time = ts,
            };

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = this.ingredientsRespository.All().FirstOrDefault(x => x.Name == inputIngredient.Name);
                if (ingredient == null)
                {
                    ingredient = new Ingredient { Name = inputIngredient.Name };
                }

                recipe.Ingredients.Add(ingredient);
            }

            foreach (var inputSteps in input.Steps)
            {
                var step = this.stepsRespository.All().FirstOrDefault(x => x.Description == inputSteps.Description);
                if (step == null)
                {
                    step = new Step { Description = inputSteps.Description };
                }

                recipe.Steps.Add(step);
            }

            await this.recipesRepository.AddAsync(recipe);
            await this.recipesRepository.SaveChangesAsync();
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