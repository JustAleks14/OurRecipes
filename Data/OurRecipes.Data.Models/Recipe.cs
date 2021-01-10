namespace OurRecipes.Data.Models
{
    using System;
    using System.Collections.Generic;

    using OurRecipes.Data.Common.Models;

    using OurRecipes.Data.Models.Enums;

    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.Comments = new HashSet<Comment>();
            this.Ingredients = new HashSet<Ingredient>();
        }

        public string Name { get; set; }

        public ApplicationUser Chief { get; set; }

        public TimeSpan Time { get; set; }

        public string Type { get; set; }

        public DifficultyLevel DifficultyLevel { get; set; }

        public int MealCount { get; set; }

        public string Steps { get; set; }

        public int Rating { get; set; }

        public int MyProperty { get; set; }

        public string Image { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
