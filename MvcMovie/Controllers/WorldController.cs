using Microsoft.AspNetCore.Mvc;

namespace TuNombreDeEspacioDeNombres.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
