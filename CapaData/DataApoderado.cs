using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataApoderado {
        SqlConnection conectar = new SqlConnection();
        public string IngreApode(string nom, string ape, string paretezco, string dni, string fech, string telef, string estado_c, string dirrecion, string sexo, int distri) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("ING_APO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar, 60).Value = nom;
            cmd.Parameters.Add("@APE", SqlDbType.VarChar, 60).Value = ape;
            cmd.Parameters.Add("@PAREN", SqlDbType.VarChar, 30).Value = paretezco;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = dni;
            cmd.Parameters.Add("@NAC", SqlDbType.DateTime).Value = fech;
            cmd.Parameters.Add("@TELF", SqlDbType.VarChar, 9).Value = telef;
            cmd.Parameters.Add("@EST", SqlDbType.VarChar, 25).Value = estado_c;
            cmd.Parameters.Add("@DIREC", SqlDbType.VarChar, 60).Value = dirrecion;
            cmd.Parameters.Add("@SEXO", SqlDbType.Char, 1).Value = sexo;
            cmd.Parameters.Add("@DISTRI", SqlDbType.Int).Value = distri;
            try {
                conectar.Open();
                cmd.ExecuteNonQuery();
                conectar.Close();
                return "Todo Ok";
            } catch(Exception ex) {
                conectar.Close();
                return ex.Message;
            }
        }
    }
}
