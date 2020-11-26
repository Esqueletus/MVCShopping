using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCShoppingFinal.Context;

namespace MVCShoppingFinal.Controllers
{
    public class FrontEndController : Controller
    {
        private readonly ShopDatabaseContext _context;

        public FrontEndController(ShopDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> mostrarProductos()
        {
            return View(await _context.Producto.ToListAsync()); // LISTA PRODUCTOS
        }
    }
}
