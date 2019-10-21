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

        public string IngresarUsuario(string cod, string pass, string posicion) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("INSER_USU", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@COD", SqlDbType.VarChar, 10).Value = cod;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 15).Value = pass;
            cmd.Parameters.Add("@POSICION", SqlDbType.VarChar, 15).Value = posicion;
            try {
                conectar.Open();
                cmd.ExecuteNonQuery();
                conectar.Close();
                return "Todo ok";
            } catch(Exception e) {
                return e.Message;
            }
        }
    }
}
