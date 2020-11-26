using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MVCShopping.Models {
    public class Negocio {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int idNegocio { get; set; }
        [Required(ErrorMessage = "Se necesita un nombre.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se necesita un numero.")]
        public string Numero { get; set; }
        public ICollection<Producto> Productos { get; set; }

        //ej https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
        // https://www.entityframeworktutorial.net/efcore/pmc-commands-for-ef-core-migration.aspx
        // https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx

        public bool agregarProducto() {
            //
            return false;
        }

        public bool modificarProducto() {
            //
            return false;
        }

        public bool eliminarProducto() {
            //
            return false;
        }

        public Producto buscarProducto(String nombreProd) {
            Producto producto = null;
            //
            return producto;
        }

        public void listarProductos() {
            //
        }

        // ---------------------------------------------------------------------------------------VERIFICAR
        /*public List<Producto> FiltrarProductoPorCategoria(CategoriaProducto categoria) {
            List<Producto> productosPorCat = new List<Producto>();
            //
            return productosPorCat;

        }*/

        public ICollection<Producto> ordenarPorPrecioMaxAMin() {
            List<Producto> productosOrdMax = new List<Producto>();
            //
            return productosOrdMax;
        }

        public ICollection<Producto> ordenarPorPrecioMinAMax() {
            List<Producto> productosOrdMax = new List<Producto>();
            //
            return productosOrdMax;
        }

        public ICollection<Producto> ordenarPorPrecioMinYMax(float min, float max) {
            List<Producto> productosOrdMaxMin = new List<Producto>();
            //
            return productosOrdMaxMin;
        }

    }
}