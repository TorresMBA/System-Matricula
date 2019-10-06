using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNDocente {
        CapaData.DataDocente obj = new CapaData.DataDocente();
        public DataTable ListarDocen() {
            return obj.ListarDocen();
        }
    }
}
