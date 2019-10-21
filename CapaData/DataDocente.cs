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

        public int IngresarPerso(int idper, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("ING_PER", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDPER", SqlDbType.Int).Value = idper;
            cmd.Parameters["@IDPER"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@NOM", SqlDbType.VarChar, 60).Value = nom;
            cmd.Parameters.Add("@APE", SqlDbType.VarChar, 60).Value = ape;
            cmd.Parameters.Add("@TELF", SqlDbType.VarChar, 9).Value = telef;
            cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = foto;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = dni;
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 70).Value = email;
            cmd.Parameters.Add("@SEXO", SqlDbType.Char, 1).Value = sexo;
            cmd.Parameters.Add("@NAC", SqlDbType.DateTime).Value = fech;
            cmd.Parameters.Add("@EST", SqlDbType.Char, 1).Value = "A";
            cmd.Parameters.Add("@DIREC", SqlDbType.VarChar, 60).Value = dirrecion;
            cmd.Parameters.Add("@IDDIS", SqlDbType.Int).Value = distri;
            cmd.Parameters.Add("@NIVEL", SqlDbType.VarChar, 25).Value = "Docente";
            try {
                conectar.Open();
                cmd.ExecuteNonQuery();
                return int.Parse(cmd.Parameters[0].Value.ToString());
            } catch(Exception e) {
                conectar.Close();
                return 0;
            }
        }

        public int IngresarEmple(int idgen, float sueldo, string horas, int id_perso) {
            SqlCommand cmd = new SqlCommand("ACTUALIZAR_EMPLE", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDEMPLE", SqlDbType.Int).Value = idgen;
            cmd.Parameters["@IDEMPLE"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@SUELDO", SqlDbType.Float).Value = sueldo;
            cmd.Parameters.Add("@HORAS", SqlDbType.VarChar).Value = horas;
            cmd.Parameters.Add("@IDPERSO", SqlDbType.Int).Value = id_perso;
            try {
                if(conectar.State == ConnectionState.Closed) {
                    conectar.Open();
                }
                cmd.ExecuteNonQuery();
                conectar.Close();
                return int.Parse(cmd.Parameters[0].Value.ToString());
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public string IngresarDocente(int idem, string area) {
            SqlCommand cmd = new SqlCommand("ING_MAESTRO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDEMPLE", SqlDbType.Int).Value = idem;
            cmd.Parameters.Add("@AREADOCEN", SqlDbType.VarChar, 50).Value = area;
            try {
                if(conectar.State == ConnectionState.Closed) {
                    conectar.Open();
                }
                cmd.ExecuteNonQuery();
                conectar.Close();
                return "Todo ok";
            } catch(Exception ex) {
                return ex.Message;
            }
        }

        public string ModificarEmple(int id, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri, byte[] foto) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("MODF_ALUM", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@NOM", SqlDbType.VarChar, 30).Value = nom;
            cmd.Parameters.Add("@APE", SqlDbType.VarChar, 30).Value = ape;
            cmd.Parameters.Add("@TELF", SqlDbType.Char, 9).Value = telef;
            cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 9).Value = dni;
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 40).Value = email;
            cmd.Parameters.Add("@SEXO", SqlDbType.Char, 1).Value = sexo;
            cmd.Parameters.Add("@NAC", SqlDbType.DateTime).Value = fech;
            cmd.Parameters.Add("@EST", SqlDbType.Char, 1).Value = "A";
            cmd.Parameters.Add("@DIREC", SqlDbType.VarChar, 60).Value = dirrecion;
            cmd.Parameters.Add("@IDDIS", SqlDbType.Int).Value = distri;
            cmd.Parameters.Add("@FOTO", SqlDbType.Image).Value = foto;
            try {
                conectar.Open();
                cmd.ExecuteNonQuery();
                conectar.Close();
                return "Todo Ok";
            } catch(Exception e) {
                conectar.Close();
                return e.Message;
            }
        }

        public DataTable ListarDocen() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter dr = new SqlDataAdapter("LISTAR_MAEST", conectar);
            dr.Fill(tb);
            return tb;
        }

        public DataTable BuscarEmpleID(string cod) {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("BUSCAR_EMPLEID '" + cod + "'", conectar);
            da.Fill(tb);
            return tb;
        }
    }
}
