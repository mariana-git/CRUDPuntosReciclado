using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class CDEjecutarNonQuery : CDConexion
    {
        internal int NonQueryQ(string query)
        {
            //Método para realizar todas las consultas en modo desconectado
            using (SqlConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (SqlCommand Comando = new SqlCommand(query, Conexion))
                {
                    return Comando.ExecuteNonQuery();
                }
            }
        }
    }
}
