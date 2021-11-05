using System.Data;
using System.Data.OleDb;

namespace Datos
{
    class CDEjecutarNonQuery : CDConexion
    {
        internal int NonQuery(string query)
        {
            //Método para realizar todas las consultas en modo desconectado
            using (OleDbConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                {
                    return Comando.ExecuteNonQuery();
                }
            }
        }
    }
}
