using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
