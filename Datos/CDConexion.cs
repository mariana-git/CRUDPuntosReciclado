using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class CDConexion
    {
        private readonly string cadena;

        public CDConexion() => cadena = "server= localhost ; database= PuntosDeReciclado ; integrated security = true";

        protected SqlConnection Conectar()
        {
            SqlConnection sqlConnection = new SqlConnection(cadena);
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
