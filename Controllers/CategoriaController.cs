using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea___MVC.Data;
using Tarea___MVC.Models;

namespace Tarea___MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var Categorias = await _context.Categorias.ToListAsync();
            return View(Categorias);
        }

        public async Task<IActionResult> Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }
    }

    
}
