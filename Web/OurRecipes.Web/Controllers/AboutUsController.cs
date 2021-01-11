namespace OurRecipes.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OurRecipes.Web.ViewModels;

    public class AboutUsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
