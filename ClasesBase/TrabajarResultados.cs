using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarResultados
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable mostrarResultados(int idCompetencia) 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "mostrarResultados";

            cmd.Parameters.AddWithValue("@id", idCompetencia);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int cantidadAtletasAbandonaron(int idCompetencia) 
        {
            int atletasAbandonaron;

            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contarAtleasAbandonaron";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCompetencia", idCompetencia);

            cmd.Parameters.Add("@atletasAbandonaron", SqlDbType.Int);
            cmd.Parameters["@atletasAbandonaron"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            atletasAbandonaron = (int)cmd.Parameters["@atletasAbandonaron"].Value;

            return atletasAbandonaron;
        }

        public static int cantidadAtletasDescalificados(int idCompetencia) 
        {
            int atletasDescalificados;

            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contarAtleasDescalificados";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCompetencia", idCompetencia);

            cmd.Parameters.Add("@atletasDescalificados", SqlDbType.Int);
            cmd.Parameters["@atletasDescalificados"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            atletasDescalificados = (int)cmd.Parameters["@atletasDescalificados"].Value;

            return atletasDescalificados;
        }
    }
}
