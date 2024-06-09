using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDisciplina
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable ListarDisciplinas() 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarDisciplinas";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertarDisciplina(Disciplina oDisciplina) 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombre", oDisciplina.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", oDisciplina.Dis_Descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarDisciplina(Disciplina oDisciplina)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", oDisciplina.Dis_ID);
            cmd.Parameters.AddWithValue("@nombre", oDisciplina.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", oDisciplina.Dis_Descripcion);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarDisciplina(Disciplina oDisciplina)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarDisciplina";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", oDisciplina.Dis_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
