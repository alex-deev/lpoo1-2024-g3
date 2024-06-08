using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarParticipante
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        //LISTAR PARTICIPANTES
        public static DataTable ListarParticipantes()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT " +
                              "ID as 'Id', " +
                              "DNI as 'DNI', " +
                              "Apellido as 'Apellido', " +
                              "Nombre as 'Nombre', " +
                              "Nacionalidad as 'Nacionalidad', " +
                              "Entrenador as 'Entrenador', " +
                              "Genero as 'Genero', " +
                              "Altura as 'Altura', " +
                              "Peso as 'Peso', " +
                              "FechaNac as 'FechaNac', " +
                              "Direccion as 'Direccion', " +
                              "Email as 'Email' " +
                              "FROM Atleta";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //INSERTAR PARTICIPANTE
        public static void guardarParcticipante(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Atleta(DNI, Apellido, Nombre, Nacionalidad, Entrenador, Genero, Altura, Peso, FechaNac, Direccion, Email) " +
                              "VALUES (@dni, @apellido, @nombre, @nacionalidad, @entrenador, @genero, @altura, @peso, @fechaNac, @direccion, @email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", atleta.Atl_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //ELIMINAR PARTICIPANTE
        public static void eliminarParticipante(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Atleta WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", atleta.Atl_ID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //MODIFICAR PARTICIPANTE
        public static void modificarParticipante(Atleta atleta)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Atleta SET " +
                                 "DNI = @dni, " +
                                 "Apellido = @apellido, " +
                                 "Nombre = @nombre, " +
                                 "Nacionalidad = @nacionalidad, " +
                                 "Entrenador = @entrenador, " +
                                 "Genero = @genero, " +
                                 "Altura = @altura, " +
                                 "Peso = @peso, " +
                                 "FechaNac = @fechaNac, " +
                                 "Direccion = @direccion, " +
                                 "Email = @email " +
                                 "WHERE ID = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", atleta.Atl_ID);
            cmd.Parameters.AddWithValue("@dni", atleta.Atl_DNI);
            cmd.Parameters.AddWithValue("@apellido", atleta.Atl_Apellido);
            cmd.Parameters.AddWithValue("@nombre", atleta.Atl_Nombre);
            cmd.Parameters.AddWithValue("@nacionalidad", atleta.Atl_Nacionalidad);
            cmd.Parameters.AddWithValue("@entrenador", atleta.Atl_Entrenador);
            cmd.Parameters.AddWithValue("@genero", atleta.Atl_Genero);
            cmd.Parameters.AddWithValue("@altura", atleta.Atl_Altura);
            cmd.Parameters.AddWithValue("@peso", atleta.Atl_Peso);
            cmd.Parameters.AddWithValue("@fechaNac", atleta.Atl_FechaNac);
            cmd.Parameters.AddWithValue("@direccion", atleta.Atl_Direccion);
            cmd.Parameters.AddWithValue("@email", atleta.Atl_Email);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //METODO BOOL PARA VERIFICAR SI YA EXISTE UN PARTICIPANTE CON EL MISMO DNI
        public static bool verificarAtletaRepetido(string dni)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Atleta WHERE DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            return count > 0;
        }

        public static DataTable listarAtletaPorDni()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "listarAtleta";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable listarAtletaPorApellido()
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;

            da.SelectCommand.CommandText = "listarAtletaPorApellido";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
