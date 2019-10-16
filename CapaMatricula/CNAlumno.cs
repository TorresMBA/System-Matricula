using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNAlumno {
        CapaData.DataAlumno obj = new CapaData.DataAlumno();
        public DataTable ListarAlum() {
            return obj.ListarAlum();
        }

        public DataTable ListarAlumNoMatric() {
            return obj.ListarAlumNoMatric();
        }
        public int IngresarPerso(int idper, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            return obj.IngresarPerso(idper, nom, ape, telef, dni, email, sexo, fech, dirrecion, distri, foto);
        }

        public DataTable IngresarAlum(int id_carrera, int id_perso) {
            return obj.IngresarAlum(id_carrera, id_perso);
        }
        
        /*public DataTable ListarUltAlum() {
            return obj.ListarUltAlum();
        }*/

        public DataTable BuscarAlumID(string cod) {
            return obj.BuscarAlumID(cod);
        }

        public DataTable BuscarCursosID(string cod) {
            return obj.BuscarCursosID(cod);
        }

        public DataTable BuscarAlum(int num, string cod_a, string ape) {
            return obj.BuscarAlum(num, cod_a, ape);
        }

        public string ModificarAlum(int id, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            return obj.ModificarAlum(id, nom, ape, telef, dni, email, sexo, fech, dirrecion, distri, foto);
        }

        public string EliminarAlum() {
            return "#";     
        }
    }
}
