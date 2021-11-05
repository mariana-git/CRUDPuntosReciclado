using System.Data;
using System.Data.OleDb;

namespace Datos
{
    class CDEjecutarReader : CDConexion
    {
        internal DataTable Reader(string sentencia)
        {
            using (OleDbConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (OleDbCommand Comando = new OleDbCommand(sentencia, Conexion))
                {
                    Comando.CommandTimeout = 10;
                    OleDbDataReader leer = Comando.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
    }
}
