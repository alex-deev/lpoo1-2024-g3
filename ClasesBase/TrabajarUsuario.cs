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
            cmd.CommandText = "listarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "insertarUsuario";

            cmd.Parameters.AddWithValue("@nombre_usuario", u.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", u.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido_nombre", u.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_codigo", u.Rol_Codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ActualizarUsuario(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "actualizarUsuario";

            cmd.Parameters.AddWithValue("@id", u.Usu_ID);
            cmd.Parameters.AddWithValue("@nombre_usuario", u.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", u.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido_nombre", u.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol_codigo", u.Rol_Codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarUsuario(Usuario u)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminarUsuario";
            cmd.Parameters.AddWithValue("@id", u.Usu_ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable BuscarUsuarios(string patron)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarUsuarios";

            cmd.Parameters.AddWithValue("@patron", "%" + patron + "%");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListarRoles()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarRoles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataRow BuscarUsuarioAutenticar(string nombreUsuario, string contrasenia)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarUsuarioAutenticar";

            cmd.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Select().Length == 1)
            {
                return dt.Select().First();
            }
            else
            {
                return null;
            }
        }

        public static Usuario ConvertirUsuario(DataRow dr)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Usu_ID = (int)dr["ID"];
            oUsuario.Usu_NombreUsuario = (string)dr["NombreUsuario"];
            oUsuario.Usu_Contraseña = (string)dr["Contrasenia"];
            oUsuario.Usu_ApellidoNombre = (string)dr["ApellidoNombre"];
            oUsuario.Rol_Codigo = (int)dr["Rol_Codigo"];
            return oUsuario;
        }
    }
}
