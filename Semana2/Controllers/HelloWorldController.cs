using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Semana2.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/ Reemplazar el método index:

        public IActionResult Index()
        {
            return View();
        }

        //
        //GET: /HelloWorld/Welcome/ Agregar este método:

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hola mi querido amigo " + name;
            ViewData["NumTimes"] = numTimes;


            return View();
        }
    }
}
