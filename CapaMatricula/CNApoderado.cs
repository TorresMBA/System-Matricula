using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio {
    public class CNApoderado {
        CapaData.DataApoderado obj = new CapaData.DataApoderado();
        public string IngApode(string nom, string ape, string paretezco, string dni, string fech, string telef, string estado_c, string dirrecion, string sexo, int distri) {
            return obj.IngreApode(nom, ape, paretezco, dni, fech, telef, estado_c, dirrecion, sexo, distri);
        }
    }
}
