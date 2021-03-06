﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCShopping.Models;
using MVCShoppingFinal.Context;

namespace MVCShoppingFinal.Controllers
{
    public class ProductoesController : Controller
    {
        private readonly ShopDatabaseContext _context;

        public ProductoesController(ShopDatabaseContext context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Producto.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.idProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }
        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var negocios = from negocio in _context.infoNegocio select negocio.idNegocio;
            ViewBag.neg = new SelectList(negocios);

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idProducto,nombre,descripcion,precio,talle,ColorProd,CategoriaProd,CurrentNegocioId")] Producto producto)
        {
            if (id != producto.idProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.idProducto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.idProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.idProducto == id);
        }

        /*-------------*/

        // GET: Productoes/Create
        public IActionResult Create(int idNegocio)
        {
            var cq = from d in _context.infoNegocio
                     orderby d.Nombre
                     select new { Id = d.idNegocio, Value = d.Nombre };

            ViewBag.neg = new SelectList(cq.Distinct(), "Id", "Value"); //El distinct evita que se repitan valores.
            return View();
        }

        public IActionResult crearProdConIDNegocio(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
       
            ViewBag.neg = id;

            return View("Create2");
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idProducto,nombre,descripcion,precio,talle,ColorProd,CategoriaProd,CurrentNegocioId")] Producto producto)
        {
            //USAR BUSCARID(VALOR)
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        //VER QUE FUNCIONE
        private int BuscarId(string nombreNegocio) {
            string id = _context.Producto
                .FromSqlRaw("SELECT idNegocio FROM infoNegocio WHERE Nombre = {asd}", nombreNegocio)
                .ToString();
            int idRetorno = Convert.ToInt32(id);
            return idRetorno;
        }
    }
}
