using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarEvento
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataRow BuscarEvento(int idCompetencia, int idParticipante)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarEventoPorCompetenciaYParticipante";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCompetencia", idCompetencia);
            cmd.Parameters.AddWithValue("@idParticipante", idParticipante);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Select().Count() == 0)
            {
                return null;
            } else {
                return dt.Select().First();
            }
        }

        public static DataTable ListarParticipantesPorCompetencia(int idCompetencia)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarParticipantesPorCompetencia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCompetencia", idCompetencia);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void ActualizarHoraInicio(int idEvento, DateTime horaInicio)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarEventoHoraInicio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idEvento);
            cmd.Parameters.AddWithValue("@horaInicio", horaInicio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarHoraFin(int idEvento, DateTime horaFin)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarEventoHoraFin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idEvento);
            cmd.Parameters.AddWithValue("@horaFin", horaFin);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void CambiarEstado(int idEvento, string estado)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarEventoEstado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idEvento);
            cmd.Parameters.AddWithValue("@estado", estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Evento ConvertirEvento(DataRow dr)
        {
            Evento oEvento = new Evento();
            oEvento.Eve_ID = (int) dr["ID"];
            oEvento.Eve_Estado = (string) dr["Estado"];
            oEvento.Com_ID = (int) dr["Com_ID"];
            oEvento.Atl_ID = (int) dr["Atl_ID"];

            if (dr.IsNull("HoraInicio")) { oEvento.Eve_HoraInicio = DateTime.MinValue; }
            else { oEvento.Eve_HoraInicio = Convert.ToDateTime(dr["HoraInicio"]); }
            if (dr.IsNull("HoraFin")) { oEvento.Eve_HoraFin = DateTime.MinValue; }
            else { oEvento.Eve_HoraFin = Convert.ToDateTime(dr["HoraFin"]); } 
            
            return oEvento;
        }
    }
}
