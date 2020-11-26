using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCShopping.Models;
using MVCShoppingFinal.Context;

namespace MVCShoppingFinal.Controllers {
    public class HomeController : Controller {

        private readonly ShopDatabaseContext _context;

        public HomeController(ShopDatabaseContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult SeleccionoColor() {
            ViewBag.colores = Enum.GetValues(typeof(ColorProducto)).Cast<ColorProducto>();

            return View();
        }

        [HttpPost]
        public IActionResult SeleccionoColor(ColorProducto color) {
            int idColor = ValidarId(color);
            List<Producto> prodsXColor = _context.Producto
                .FromSqlRaw("SELECT * FROM Producto WHERE ColorProd = {0}", idColor)
                .ToList();
            return FiltradoXColor(prodsXColor);
        }
        public IActionResult FiltradoXColor(List<Producto> prodsXColorr) {

            ViewBag.prods = prodsXColorr;
            return View("FiltradoXColor");

        }

        private int ValidarId(ColorProducto color) {
            if(color == ColorProducto.ROJO) {
                return 0;
            }
            if (color == ColorProducto.ROSA)
            {
                return 1;
            }
            if (color == ColorProducto.VERDE)
            {
                return 2;
            }
            if (color == ColorProducto.AMARILLO)
            {
                return 3;
            }
            if (color == ColorProducto.NEGRO)
            {
                return 4;
            }
            if (color == ColorProducto.BLANCO)
            {
                return 5;
            }
            if (color == ColorProducto.GRIS)
            {
                return 6;
            } else {
                return -1;
            }
        }
    }
}
