using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataUsuario {
        SqlConnection conectar = new SqlConnection();
        public DataTable ListarUsu() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("LISTAR_USU", conectar);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
