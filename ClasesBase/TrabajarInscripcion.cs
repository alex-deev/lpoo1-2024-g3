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

        public static List<Competencia> ObtenerCompetenciasDisponibles()
        {
            List<Competencia> competencias = new List<Competencia>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ObtenerCompetenciasDisponibles", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Competencia competencia = new Competencia
                    {
                        Com_ID = Convert.ToInt32(reader["ID"]),
                        Com_Nombre = reader["Nombre"].ToString(),
                        Com_Descripcion = reader["Descripcion"].ToString(),
                        Com_FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        Com_FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                        Com_Estado = reader["Estado"].ToString(),
                        Com_Organizador = reader["Organizador"].ToString(),
                        Com_Ubicacion = reader["Ubicacion"].ToString(),
                        Com_Sponsors = reader["Sponsors"].ToString(),
                        Cat_ID = Convert.ToInt32(reader["Cat_ID"]),
                        Dis_ID = Convert.ToInt32(reader["Dis_ID"])
                    };
                    competencias.Add(competencia);
                }
                reader.Close();
            }
            return competencias;
        }

        public static string InscribirAtleta(int atletaId, int competenciaId)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("InscribirAtleta", conn);
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
    }
}