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
            cmd.CommandText = " SELECT ";
            cmd.CommandText = " C.Nombre as 'Nombre', ";
            cmd.CommandText = " T.Nombre as 'Categoría', ";
            cmd.CommandText = " D.Nombre as 'Disciplina', ";
            cmd.CommandText = " C.Descripcion as 'Descripción', ";
            cmd.CommandText = " C.FechaInicio as 'Inicio', ";
            cmd.CommandText = " C.FechaFin as 'Fin', ";
            cmd.CommandText = " C.Estado as 'Estado', ";
            cmd.CommandText = " C.Organizador as 'Organizador', ";
            cmd.CommandText = " C.Ubicacion as 'Ubicación', ";
            cmd.CommandText = " C.Sponsors as 'Sponsors' ";
            cmd.CommandText = " FROM Competencia as C ";
            cmd.CommandText = " LEFT JOIN Categoria as T ";
            cmd.CommandText = "     ON C.Cat_ID=T.ID ";
            cmd.CommandText = " LEFT JOIN Disciplina as D ";
            cmd.CommandText = "     ON C.Dis_ID=D.ID ";
            cmd.CommandType = CommandType.Text;
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
            cmd.CommandText = " INSERT INTO ";
            cmd.CommandText = " Competencia (Nombre, Descripcion, FechaInicio, FechaFin, Estado, Organizador, Ubicacion, Sponsors, Cat_ID, Dis_ID) ";
            cmd.CommandText = " VALUES (@nombre, @descripcion, @fechaInicio, @fechaFin, @estado, @organizador, @ubicacion, @sponsors, @cat_id, @dis_id) ";

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
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarCompetencia(Competencia c)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " UPDATE Competencia SET ";
            cmd.CommandText = " (Nombre=@nombre, Descripcion=@descripcion, FechaInicio=@fechaInicio, FechaFin=@fechaFin, Estado=@estado, Organizador=@organizador, Ubicacion=@ubicacion, Sponsors=@sponsors, Cat_ID=@cat_id, Dis_ID=@dis_id) ";
            cmd.CommandText = " WHERE ID=@id";

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
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarCompetencia(Competencia c)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE Competencia WHERE ID=@id";
            cmd.Parameters.AddWithValue("@id", c.Com_ID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
