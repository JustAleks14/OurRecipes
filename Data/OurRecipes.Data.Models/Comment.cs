namespace OurRecipes.Data.Models
{
    using OurRecipes.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public ApplicationUser Author { get; set; }

        public Recipe Recipe { get; set; }

        public int Rating { get; set; }
    }
}
