using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Datos
{
    public class CDEjecutarReader : CDConexion
    {
        public DataTable Reader(string sentencia)
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
