using Microsoft.AspNetCore.Mvc;

namespace coreMvcConfigurationProject.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View("AboutView");
        }
        public ViewResult Details()
        {
            return View();
        }
        public ViewResult Message()
        {
            return View();
        }

    }
}
