using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable ListarUsuarios()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " R.Descripcion as 'Rol', ";
            cmd.CommandText += " U.ApellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " U.NombreUsuario as 'Usuario', ";
            cmd.CommandText += " U.Contrasenia as 'Contraseña', ";
            cmd.CommandText += " U.ID as 'ID', R.Codigo as 'Codigo Rol' ";
            cmd.CommandText += " FROM Usuario as U ";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Codigo=U.Rol_Codigo) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void InsertarUsuario(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario (NombreUsuario, Contrasenia, ApellidoNombre, Rol_Codigo) ";
            cmd.CommandText += " VALUES (@usuario, @contra, @ape_nom, @rol_cod) ";
            cmd.Parameters.AddWithValue("@usuario", u.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contra", u.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@ape_nom", u.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_cod", u.Rol_Codigo);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarUsuario(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET NombreUsuario=@usuario, Contrasenia=@contra, ";
            cmd.CommandText += " ApellidoNombre=@ape_nom, Rol_Codigo=@rol_cod ";
            cmd.CommandText += " WHERE ID=@id";
            cmd.Parameters.AddWithValue("@id", u.Usu_ID);
            cmd.Parameters.AddWithValue("@usuario", u.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contra", u.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@ape_nom", u.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_cod", u.Rol_Codigo);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarUsuario(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE Usuario WHERE ID=@id";
            cmd.Parameters.AddWithValue("@id", u.Usu_ID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable ListarRoles()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
