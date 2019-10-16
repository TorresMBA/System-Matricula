using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaData;

namespace CapaNegocio {
    public class CNUtilitario {
        DataUtilitario dt = new DataUtilitario();
        public DataTable DBLis() {
            return dt.DBLis();
        }

        public string BackUp(string db, string etiq, byte tipo) {
            return dt.BackUp(db, etiq, tipo);
        }

        public string Restaurar(string db, string copia) {
            return dt.Restaurar(db, copia);
        }
    }
}
