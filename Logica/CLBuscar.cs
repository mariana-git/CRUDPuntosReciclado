using System.Data;
using Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CLBuscar
    {        
        public string Parametro { private get; set; }

        public DataTable Buscar ()
        {
            CDBuscar cDBuscar = new CDBuscar();
            if(Parametro != string.Empty)
            {
                if (int.TryParse(Parametro, out int numero))
                {
                    using (DataTable DT = cDBuscar.BuscarConParametro(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.BuscarConParametro(Parametro))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.BuscarSinParametro())
                {
                    return DT;
                }
            }
        }
    }
}
