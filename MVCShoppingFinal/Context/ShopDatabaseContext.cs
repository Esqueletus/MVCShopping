using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCShopping.Models;

namespace MVCShoppingFinal.Context {
    public class ShopDatabaseContext : DbContext {
        public ShopDatabaseContext(DbContextOptions<ShopDatabaseContext> options) : base(options) {
        }
        public DbSet<Negocio> infoNegocio { get; set; }
    }
}