namespace OurRecipes.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;

    using OurRecipes.Data.Models;
    using OurRecipes.Data.Models.Enums;

    public class RecipeInfoViewModel
    {
        public RecipeInfoViewModel()
        {
            this.Steps = new List<Step>();
        }

        public string Image { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Time { get; set; }

        public int MealCount { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public ICollection<Step> Steps { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
