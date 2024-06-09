using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCompetencia
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable ListarCompetencias()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= "listarCompetencias";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertarCompetencia(Competencia c)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarCompetencia";
            cmd.Parameters.AddWithValue("@nombre", c.Com_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", c.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", c.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", c.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", c.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", c.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", c.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", c.Com_Sponsors);
            cmd.Parameters.AddWithValue("@cat_id", c.Cat_ID);
            cmd.Parameters.AddWithValue("@dis_id", c.Dis_ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarCompetencia(Competencia c)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarCompetencia";
            cmd.Parameters.AddWithValue("@id", c.Com_ID);
            cmd.Parameters.AddWithValue("@nombre", c.Com_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", c.Com_Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", c.Com_FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", c.Com_FechaFin);
            cmd.Parameters.AddWithValue("@estado", c.Com_Estado);
            cmd.Parameters.AddWithValue("@organizador", c.Com_Organizador);
            cmd.Parameters.AddWithValue("@ubicacion", c.Com_Ubicacion);
            cmd.Parameters.AddWithValue("@sponsors", c.Com_Sponsors);
            cmd.Parameters.AddWithValue("@cat_id", c.Cat_ID);
            cmd.Parameters.AddWithValue("@dis_id", c.Dis_ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarCompetencia(Competencia c)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarCompetencia";
            cmd.Parameters.AddWithValue("@id", c.Com_ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
