using System.Data;
using Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CLBuscar
    {        
        public string Palabra { private get; set; }

        public DataTable PersonaPunto ()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if(Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.PersonaPunto(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.PersonaPunto(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.PersonaPunto())
                {
                    return DT;
                }
            }
        }
        public DataTable Punto ()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Punto(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Punto(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Punto())
                {
                    return DT;
                }
            }
        }
        public DataTable Persona()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Persona(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Persona(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Persona())
                {
                    return DT;
                }
            }
        }
    }
}
