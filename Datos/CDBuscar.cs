using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Datos
{
    public class CDBuscar
    {
        private string sentencia;

        public DataTable BuscarSinParametro()
        {
            sentencia = "SELECT denominacion, DiasYHorarios, espacio, direccion, nombre, apellido, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                "INNER JOIN Personas p ON pp.idPersona=p.idPersona;";
            
            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable BuscarConParametro(string parametro)
        {
            sentencia = "SELECT denominacion, DiasYHorarios, espacio, direccion, nombre, apellido, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                $"INNER JOIN Personas p ON pp.idPersona=p.idPersona WHERE denominacion LIKE '%{parametro}%' OR " +
                $" espacio LIKE '%{parametro}%' OR direccion LIKE '%{parametro}%' OR nombre LIKE '%{parametro}%' OR " +
                $"apellido LIKE '%{parametro}%'OR responsabilidad LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable BuscarConParametro(int parametro)
        {
            sentencia = "SELECT denominacion, DiasYHorarios, espacio, direccion, nombre, apellido, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                $"INNER JOIN Personas p ON pp.idPersona=p.idPersona WHERE p.idPersona LIKE '%{parametro}%' OR " +
                $" pr.idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
    }
}
