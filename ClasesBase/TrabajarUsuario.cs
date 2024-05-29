using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarUsuario
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
            cmd.CommandText += " U.ID as 'ID', R.Codigo as 'Codigo Rol', ";
            cmd.CommandText += " FROM Usuario as U ";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.Codigo=U.Rol_Codigo) ";
            cmd.CommandType = CommandType.Text;
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
