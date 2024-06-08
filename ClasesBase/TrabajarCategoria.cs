using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarCategoria
    {
            static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

            public static DataTable ListarCategorias()
            {               
                    SqlConnection cnn = new SqlConnection(cadenaConexion);
                   
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT ";
                    cmd.CommandText += " Nombre, ";
                    cmd.CommandText += " Descripcion, ";
                    cmd.CommandText += " ID ";
                    cmd.CommandText += " FROM Categoria";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cnn;
        
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;               
            }

            public static void InsertarCategoria(Categoria oCategoria)
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Categoria (Nombre, Descripcion) ";
                cmd.CommandText += " VALUES (@nombre, @descripcion) ";
                cmd.Parameters.AddWithValue("@nombre", oCategoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@descripcion", oCategoria.Cat_Descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            public static void ActualizarCategoria(Categoria oCategoria)
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Categoria SET Nombre=@nombre, Descripcion=@descripcion ";
                cmd.CommandText += " WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", oCategoria.Cat_ID);
                cmd.Parameters.AddWithValue("@nombre", oCategoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@descripcion", oCategoria.Cat_Descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            public static void EliminarCategoria(Categoria oCategoria)
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE Categoria WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", oCategoria.Cat_ID);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
      }
}

