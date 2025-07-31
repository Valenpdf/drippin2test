using Drippin.Data;
using Drippin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Drippin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DrippinContext _context;

        public HomeController(ILogger<HomeController> logger, DrippinContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Obtené un producto destacado (podés modificar este criterio según tu diseño)
            var productoDestacado = _context.Producto.FirstOrDefault(p => p.EsDestacado); // o cualquier filtro

            // También pasás la lista de productos normales si la usás en el ViewBag
            ViewBag.Productos = _context.Producto
                .Where(p => p.Disponible && p != productoDestacado)
                .ToList();

            return View(productoDestacado); // Esto es lo que recibe tu vista como "Model"
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
