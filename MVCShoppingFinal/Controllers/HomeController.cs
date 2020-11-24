using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public ActionResult SeleccionoColor() {
            ViewBag.colors = new SelectList(Enum.GetNames(typeof(ColorProducto)), ColorProducto.AMARILLO);
            return View();
        }

        [HttpGet]
        public ActionResult SeleccionoColor(ColorProducto color) {
            ViewBag.colors = new SelectList(Enum.GetNames(typeof(ColorProducto)), ColorProducto.AMARILLO);
            ColorProducto colores = color;
            int code = (int)colores;
            // FiltradoXColor(code);
            return View();
        }

        //listar por colores
        public IActionResult FiltradoXColor() {
            /*int code = 4;
            var filtro = _context.Producto
                .Where(x => x.ColorProd == (ColorProducto)code)
                .ToList();

            ViewBag.filtro = filtro;*/
            return View();
        }

        [HttpGet]
        public IActionResult FiltradoXColor(ColorProducto color) {
            ViewBag.colors = new SelectList(Enum.GetNames(typeof(ColorProducto)), ColorProducto.AMARILLO);
            int code = (int)Enum.Parse(color.GetType(), color.ToString());
            var filtro = _context.Producto
                    .Where(x => x.ColorProd == color)
                    .ToList();
            ViewBag.filtro = filtro;
            return View(filtro);

        }
    }
}
