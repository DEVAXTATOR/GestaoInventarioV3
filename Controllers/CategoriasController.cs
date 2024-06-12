using Microsoft.AspNetCore.Mvc;
using GestaoInventarioV3.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GestaoInventarioV3.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categorias = _context.Categorias.ToList();
            return View(categorias);
        }
    }
}
