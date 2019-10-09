using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaData {
    public class DataAlumno {
        SqlConnection conectar = new SqlConnection();

        public DataTable ListarAlum() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("LISTAR_ALUM", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarAlumNoMatric() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("LISTAR_ALUM_NOMATRI", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable ListarUltAlum() {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("ULTIMA_PERSO", conectar);
            da.Fill(tb);
            return tb;
        }

        public string IngresarPerso(string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri) {
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("ING_PER", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.Parameters.Add("@NIVEL", SqlDbType.VarChar, 20).Value = "Alumno";
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

        public DataTable IngresarAlum(int id_carrera, int id_perso) {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("ACTUALIZAR_ALUM '" + id_carrera + "', '" + id_perso + "'", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarAlumID(string cod) {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("BUSCAR_ALUM '" + cod + "'", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarCursosID(string cod) {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlDataAdapter da = new SqlDataAdapter("LISTAR_CURSOS '" + cod + "'", conectar);
            da.Fill(tb);
            return tb;
        }

        public DataTable BuscarAlum(int num, string cod_a, string ape) {
            DataTable tb = new DataTable();
            conectar.ConnectionString = DataConexion.cn;
            SqlCommand cmd = new SqlCommand("BUSCAR_ALUMD", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@num", SqlDbType.Int).Value = num;
            cmd.Parameters.Add("@COD", SqlDbType.VarChar, 20).Value = cod_a;
            cmd.Parameters.Add("@APE", SqlDbType.VarChar, 20).Value = ape;
            SqlDataAdapter read = new SqlDataAdapter(cmd);
            read.Fill(tb);
            return tb;
        }

        public string ModificarAlum(int id, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri) {
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
    }
}
