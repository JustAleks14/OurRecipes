using System.ComponentModel;

namespace OurRecipes.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using OurRecipes.Data.Models;
    using OurRecipes.Data.Models.Enums;

    public class RecipeInputModel
    {
        public RecipeInputModel()
        {
            this.Steps = new List<Step>();
            this.Ingredients = new List<Ingredient>();
        }

        [MinLength(3)]
        [Required]
        public string Name { get; set; }

        public ApplicationUser Author { get; set; }

        [Range(0, int.MaxValue)]
        public int Time { get; set; }

        [Required]
        public string Type { get; set; }

        [DisplayName("Difficulty Level")]
        public DifficultyLevel DifficultyLevel { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Meal Count")]
        public int MealCount { get; set; }

        public string Image { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Step> Steps { get; set; }
    }
}
