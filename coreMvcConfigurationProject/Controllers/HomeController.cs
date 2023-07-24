using Microsoft.AspNetCore.Mvc;

namespace coreMvcConfigurationProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index from Home Controller";
        }
        public string Contact()
        {
            return "Contact from Home Controller";
        }
    }
}
