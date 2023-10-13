using Gestor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gestor.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }

        public IActionResult Articulos()
        {
            return View();
        }


    }
}