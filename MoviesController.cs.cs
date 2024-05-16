using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace semana4.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Details/5
        // GET: Movies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Simulación de creación de un objeto Movie
            var movie = new Movie
            {
                Genre = "Terror",
                Id = 1,
                Price = 1,
                ReleaseDate = DateTime.Now,
                Title = "La noche del terror"
            };

            return View(movie);
        }
    }
}
