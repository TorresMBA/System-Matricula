using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaMatricula {
    public class CNEmpleado {
        CapaData.DataEmpleado obj = new CapaData.DataEmpleado();
        public DataTable ListarEmple() {
            return obj.ListarEmple();
        }
    }
}
