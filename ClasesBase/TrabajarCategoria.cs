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
                cmd.CommandText = "listarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.CommandText = "insertarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@nombre", oCategoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@descripcion", oCategoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            public static void ActualizarCategoria(Categoria oCategoria)
            {
                SqlConnection cnn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "actualizarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", oCategoria.Cat_ID);
                cmd.Parameters.AddWithValue("@nombre", oCategoria.Cat_Nombre);
                cmd.Parameters.AddWithValue("@descripcion", oCategoria.Cat_Descripcion);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            public static void EliminarCategoria(Categoria oCategoria)
            {

                SqlConnection cnn = new SqlConnection(cadenaConexion);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "eliminarCategoria";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cnn;

                cmd.Parameters.AddWithValue("@id", oCategoria.Cat_ID);
              
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
      }
}

