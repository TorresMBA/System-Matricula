using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNDocente {
        CapaData.DataDocente obj = new CapaData.DataDocente();

        public int IngresarPerso(int idper, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            return obj.IngresarPerso(idper, nom, ape, telef, dni, email, sexo, fech, dirrecion, distri, foto);
        }

        public int IngresarEmple(float sueldo, string horas, int id_perso) {
            return obj.IngresarEmple(0, sueldo, horas, id_perso);
        }

        public string ModificarEmple(int id, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            return obj.ModificarEmple(id, nom, ape, telef, dni, email, sexo, fech, dirrecion, distri, foto);
        }

        public string IngresarDocente(int idem, string area) {
            return obj.IngresarDocente(idem, area);
        }

        public DataTable ListarDocen() {
            return obj.ListarDocen();
        }

        public DataTable BuscarEmpleID(string cod) {
            return obj.BuscarEmpleID(cod);
        }
    }
}
