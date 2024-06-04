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
            SqlConnection cnn = new SqlConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT " +
                              "Atl_DNI as 'DNI,' " +
                              "Atl_Apellido as 'Apellido', " +
                              "Atl_Nombre as 'Nombre', " +
                              "Atl_Nacionalidad as 'Nacionalidad', " +
                              "Atl_Entrenador as 'Entrenador', " +
                              "Atl_Genero as 'Genero', " +
                              "Atl_Altura as 'Altura', " +
                              "Atl_Peso as 'Peso', " +
                              "Atl_FechaNac as 'Fecha Nac', " +
                              "Atl_Direccion as 'Direccion', " +
                              "Atl_Email as 'Email' " +
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
            cmd.CommandText = "INSERT INTO Atleta(atl_dni, atl_apellido, atl_nombre, atl_nacionalidad, atl_entrenador, atl_genero, atl_altura, atl_peso, atl_fechaNac, atl_direccion, atl_email) " +
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

            cmd.CommandText = "DELETE FROM Atleta WHERE atl_id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", atleta.Atl_ID);

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
                                 "atl_dni = @dni, " +
                                 "atl_apellido = @apellido, " +
                                 "atl_nombre = @nombre, " +
                                 "atl_nacionalidad = @nacionalidad, " +
                                 "atl_entrenador = @entrenador, " +
                                 "atl_genero = @genero, " +
                                 "atl_altura = @altura, " +
                                 "atl_peso = @peso, " +
                                 "atl_fechaNac = @fechaNac, " +
                                 "atl_direccion = @direccion, " +
                                 "atl_email = @email " +
                                 "WHERE atl_id = @id";
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

    }
}
