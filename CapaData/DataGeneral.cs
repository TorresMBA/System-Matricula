using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataGeneral {
        SqlConnection conectar = new SqlConnection();
        DataTable tb = new DataTable();
        public DataTable ListarDis() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter ra = new SqlDataAdapter("SELECT * FROM DISTRITO", conectar);
            ra.Fill(tb);
            return tb;
        }

        public DataTable ultApode() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter ra = new SqlDataAdapter("ULTIMA_APODE", conectar);
            ra.Fill(tb);
            return tb;
        }

        public DataTable ultPerso() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter ra = new SqlDataAdapter("ULTIMA_PERSO", conectar);
            ra.Fill(tb);
            return tb;
        }

        public DataTable ListarApoS() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("APODE_SIN", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarCarrera() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CARRERA", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarCiclo() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CICLO", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarSeccion () {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("LIS_SECCION", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarPersonas() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.COD_ALUM, P.NOM_PERSO, P.DNI, P.NIVEL FROM ALUMNO A INNER JOIN PERSONA P ON A.ID_PERSO = P.ID_PERSO", conectar);
            da.Fill(tb);
            return tb;
        }
        public DataTable ListarEmpleados() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT E.COD_EMPLE, P.NOM_PERSO, P.DNI, P.NIVEL FROM EMPLEADO E INNER JOIN PERSONA P ON E.ID_PERSO = P.ID_PERSO", conectar);
            da.Fill(tb);
            return tb;
        }
    }
}
