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
        [Display(Name = "ID")]
        public int idProducto { get; set; }
        [Required(ErrorMessage = "Se necesita un nombre válido.")]
        public String nombre { get; set; }
        [Required(ErrorMessage = "Se necesita una descripción válida.")]
        public String descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Ingrese un precio mayor a 0")]
        [Required(ErrorMessage = "Se necesita un precio válido.")]
        public float precio { get; set; }
        //ENUMS ---------------------
        [EnumDataType(typeof(Talle))]
        [Required(ErrorMessage = "Se necesita un talle válido.")]
        public Talle talle { get; set; }
        [EnumDataType(typeof(ColorProducto))]
        [Required(ErrorMessage = "Se necesita color válido.")]
        [Display(Name = "Color de producto")]
        public ColorProducto ColorProd { get; set; }
        [EnumDataType(typeof(CategoriaProducto))]
        [Required(ErrorMessage = "Se necesita una categoría válida.")]
        [Display(Name = "Categoria de producto")]
        public CategoriaProducto CategoriaProd { get; set; }

        [Required(ErrorMessage = "Se necesita un ID de negocio válido.")]
        [Display(Name = "Negocio que pertenece")]
        public int CurrentNegocioId { get; set; }
        public Negocio Negocio { get; set; }

    }
}