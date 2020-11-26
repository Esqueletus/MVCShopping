using MVCShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCShoppingFinal.Models
{
    public class FrontEnd
    {
        public ICollection<Producto> Productos { get; set; }
    }
}
