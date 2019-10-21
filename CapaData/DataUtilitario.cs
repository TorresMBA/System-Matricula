using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataUtilitario {
        SqlConnection conectar = new SqlConnection();
        DataTable tb = new DataTable();

        public DataTable DBLis() {
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("SELECT NAME, DBID, crdate FROM SYSDATABASES WHERE DBID > 4", conectar);
            da.Fill(tb);
            return tb;
        }
        public string BackUp(string db, string etiq, byte tipo) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("COPIADB", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DB", SqlDbType.VarChar, 30).Value = db;
            cmd.Parameters.Add("@ETIQ", SqlDbType.VarChar, 30).Value = etiq;
            cmd.Parameters.Add("@TIPO", SqlDbType.Bit).Value = tipo;
            try {
                conectar.Open();
                cmd.ExecuteNonQuery();
                conectar.Close();
                return "Todo ok";
            } catch(Exception ex) {
                return "Error: " + ex.Message;
            }
        }

            public string Restaurar(string @bd, string @copia) {
            conectar.ConnectionString = DataConexion.cn;
            try {
                SqlDataAdapter da = new SqlDataAdapter("RESTOREDB '" + @bd + "','" + @copia + "'", conectar);
                return "Restauración satisfactoria, ...";
            } catch(Exception ex) {
                return "Restauración fallida, ....";
            }
        }
    }
}
