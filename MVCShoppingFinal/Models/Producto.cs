using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCShopping.Models {
    public class Producto {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public float precio { get; set; }
        public Talle talle { get; set; }
        //agregar enum restantes
    }
}