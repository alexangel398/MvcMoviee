using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorlController : Controller
    {

        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action..."; // Retorna un mensaje predeterminado para la acción Index
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1998)
        {
            // Utiliza HtmlEncoder.Default.Encode para proteger la aplicación de entradas malintencionadas
            // Utiliza cadenas interpoladas para construir el mensaje de saludo
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
