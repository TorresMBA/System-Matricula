using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNGeneral {
        CapaData.DataGeneral obj = new CapaData.DataGeneral();
        public DataTable ListarDis() {
            return obj.ListarDis();
        }

        public DataTable ultApode() {
            return obj.ultApode();
        }

        public DataTable ultPerso() {
            return obj.ultPerso();
        }

        public DataTable ListarSec() {
            return obj.ListarSeccion();
        }

        public DataTable ListarApoS() {
            return obj.ListarApoS();
        }
        
        public DataTable ListarCarrera() {
            return obj.ListarCarrera();
        }

        public DataTable ListarCiclo() {
            return obj.ListarCiclo();
        }

        public DataTable ListarSeccion() {
            return obj.ListarSeccion();
        }

        public DataTable ListarPersonas() {
            return obj.ListarPersonas();
        }

        public DataTable ListarEmpleados() {
            return obj.ListarEmpleados();
        }
    }
}
