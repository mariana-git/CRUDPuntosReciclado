using System.Data;
using Datos;

namespace Logica
{
    public class CLBuscar
    {        
        public string Palabra { private get; set; }

        public DataTable Responsabilidades()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if(Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Responsabilidades(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Responsabilidades(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Responsabilidades())
                {
                    return DT;
                }
            }
        }

        public DataTable Puntos ()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Puntos(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Puntos(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Puntos())
                {
                    return DT;
                }
            }
        }

        public DataTable Personas()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Personas(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Personas(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Personas())
                {
                    return DT;
                }
            }
        }
    }
}
