using Microsoft.AspNetCore.Mvc;

namespace UniversityProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
