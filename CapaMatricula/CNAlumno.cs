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

        public string IngresarAlum(int id_carrera, int id_perso) {
            return obj.IngresarAlum(id_carrera, id_perso);
        }

        public string IngresarMatricula(int idalu, string turno, string periodo, int id_seccion, int id_ciclo, string fecha) {
            return obj.IngresarMatricula(idalu, turno, periodo, id_seccion, id_ciclo, fecha);
        }

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
