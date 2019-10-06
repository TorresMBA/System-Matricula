using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataEmpleado {
        SqlConnection conectar = new SqlConnection();
        public DataTable ListarEmple() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter ad = new SqlDataAdapter("LISTAR_EMPLE", conectar);
            ad.Fill(tb);
            return tb;
        }
    }
}
