using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class CDEjecutarReader : CDConexion
    {
        internal DataTable ReaderQ(string sentencia)
        {
            using (SqlConnection Conexion = Conectar())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (SqlCommand Comando = new SqlCommand(sentencia, Conexion))
                {
                    Comando.CommandTimeout = 10;
                    SqlDataReader leer = Comando.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        internal DataTable ReaderSP(string procedure)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Conectar())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.CommandText = procedure;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        internal DataTable ReaderSP(string procedure, string parametro)
        {
            using (SqlCommand Comando = new SqlCommand())
            {
                using (Comando.Connection = Conectar())
                {
                    Comando.CommandTimeout = 15;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.AddWithValue("@Parametro", parametro);
                    Comando.CommandText = procedure;
                    SqlDataReader leer = Comando.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        internal DataTable ReaderSP(string procedure, int parametro)
        {
            using (SqlCommand Comando = new SqlCommand())
            {
                using (Comando.Connection = Conectar())
                {
                    Comando.CommandTimeout = 15;
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.AddWithValue("@Parametro", parametro);
                    Comando.CommandText = procedure;
                    SqlDataReader leer = Comando.ExecuteReader();
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
