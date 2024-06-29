using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarResultados
    {
        static string cadenaConexion = ClasesBase.Properties.Settings.Default.comdepConnection;

        public static DataTable mostrarResultados(int idCompetencia) 
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "mostrarResultados";

            cmd.Parameters.AddWithValue("@id", idCompetencia);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
