using Microsoft.AspNetCore.Mvc;
using BlogProject.Controllers;


namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
