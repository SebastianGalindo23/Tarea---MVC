using Tarea___MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using Tarea___MVC.Models;

namespace Tarea___MVC.Controllers
{
    public class MarcaController : Controller
    {
        private readonly AppDbContext _context;

        public MarcaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Marcas = await _context.Marcas.ToListAsync();
            return View(Marcas);
        }

        public async Task<IActionResult> Crear(Marca Marca)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Marca);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Marca);
        }

    }

}
