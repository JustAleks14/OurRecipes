namespace OurRecipes.Web.ViewModels.Recipes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AutoMapper;
    using OurRecipes.Data.Models;
    using OurRecipes.Services.Mapping;

    public class AllRecipesViewModel : IMapFrom<Recipe>
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CommentsCount { get; set; }
    }
}
