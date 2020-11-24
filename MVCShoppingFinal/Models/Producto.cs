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
        [Required]
        public String nombre { get; set; }
        [Required]
        public String descripcion { get; set; }
        public float precio { get; set; }
        //ENUMS ---------------------
        [EnumDataType(typeof(Talle))]
        public Talle talle { get; set; }
        [EnumDataType(typeof(ColorProducto))]
        public ColorProducto ColorProd { get; set; }
        [EnumDataType(typeof(CategoriaProducto))]
        public CategoriaProducto CategoriaProd { get; set; }

        public int CurrentNegocioId { get; set; }
        public Negocio Negocio { get; set; }

    }
}