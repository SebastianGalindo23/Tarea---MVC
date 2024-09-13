using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarea___MVC.Data;
using Tarea___MVC.Models;

namespace Tarea___MVC.Controllers
{
    public class EmpleadosController: Controller
    {
        private readonly AppDbContext _context;
        public EmpleadosController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var Empleados = await _context.Empleados.ToListAsync();
            return View(Empleados);
        }

        public async Task<IActionResult> Crear(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }
    }
}

