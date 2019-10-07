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
            SqlDataAdapter ra = new SqlDataAdapter("LISTAR_DIS", conectar);
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

        public DataTable ListarSec() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter ra = new SqlDataAdapter("LISTAR_SEC", conectar);
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
    }
}
