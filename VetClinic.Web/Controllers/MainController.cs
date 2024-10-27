using Microsoft.AspNetCore.Mvc;

namespace VetClinic.Web.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
