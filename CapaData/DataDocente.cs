using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataDocente {
        SqlConnection conectar = new SqlConnection();
        public DataTable ListarDocen() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter dr = new SqlDataAdapter("LISTAR_MAEST", conectar);
            dr.Fill(tb);
            return tb;
        }
    }
}
