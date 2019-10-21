using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;

namespace CapaData {
    public class DataLogin {
        SqlConnection conectar = new SqlConnection();
        public bool Login(string user, string pass) {
            conectar.ConnectionString = DataConexion.cn;
            conectar.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conectar;
            cmd.CommandText = "SELECT * FROM USUARIO WHERE NOM_USU = @USER AND PASS = @CONTRA";
            cmd.Parameters.AddWithValue("@USER", user);
            cmd.Parameters.AddWithValue("@CONTRA", pass);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows) {
                while(reader.Read()) {
                    CacheLogin.IdUser = reader.GetInt32(0);
                    CacheLogin.NomUsu = reader.GetString(1);
                    CacheLogin.PassUsu = reader.GetString(2);
                    CacheLogin.Posiicion = reader.GetString(3);              
                }
                return true;
            } else {
                return false;
            }
            
        }
    }
}
