using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNUsuario {
        CapaData.DataUsuario usu = new CapaData.DataUsuario();
        public DataTable ListarUsu() {
            return usu.ListarUsu();
        }

        public string IngresarUsuario(string cod, string pass, string posicion) {
            return usu.IngresarUsuario(cod, pass, posicion);
        }
    }
}
