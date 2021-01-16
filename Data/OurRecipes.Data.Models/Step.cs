namespace OurRecipes.Data.Models
{
    using OurRecipes.Data.Common.Models;

    public class Step : BaseDeletableModel<int>
    {
        public string Description { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
