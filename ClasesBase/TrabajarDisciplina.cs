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
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " Nombre, ";
            cmd.CommandText += " Descripcion ";
            cmd.CommandText += " FROM Disciplina ";
            cmd.CommandType = CommandType.Text;
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
            cmd.CommandText = "INSERT INTO Disciplina (Nombre, Descripcion) ";
            cmd.CommandText += " VALUES (@nombre, @descripcion) ";
            cmd.Parameters.AddWithValue("@nombre", oDisciplina.Dis_Nombre);
            cmd.Parameters.AddWithValue("@descripcion", oDisciplina.Dis_Descripcion);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
