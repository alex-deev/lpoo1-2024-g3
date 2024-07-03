using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarInscripcion
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable ObtenerCompetenciasDisponibles() 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ObtenerCompetenciasDisponibles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable obtenerParticipantes() 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarParticipantesNombreCompleto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static string InscribirAtleta(int atletaId, int competenciaId)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("InscribirAtleta", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Atl_ID", atletaId);
                    cmd.Parameters.AddWithValue("@Com_ID", competenciaId);

                    cmd.ExecuteNonQuery();
                    return "Inscripción realizada exitosamente";
                }
                catch (SqlException ex)
                {
                    return ex.Message; // Retorna el mensaje de error del procedimiento almacenado
                }
        }

        public static DataTable ListarEventos()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand("listarEventos", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Trabajar Inscripciones TpFinal
       
    }
}