using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class CDEjecutarScalar : CDConexion
    {
        internal int ScalarQ(string query)
        {
            using (SqlConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (SqlCommand Comando = new SqlCommand(query, Conexion))
                {
                    return Convert.ToInt32(Comando.ExecuteScalar());
                }
            }
        }        
    }
}
