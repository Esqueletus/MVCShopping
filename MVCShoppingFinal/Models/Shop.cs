using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShopping.Models {
    public class Shop {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public bool agregarNegocio() {
            //
            return false;
        }

        public bool modificarNegocio() {
            //
            return false;
        }

        public bool eliminarNegocio() {
            //
            return false;
        }

        public void listarNegocios(List<Negocio> negocio) {
            //
        }

        public string buscarNegocio(string numeroNegocio) {

            return null;
        }
    }
}