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

        public DataTable PersonaPunto()
        {
            sentencia = "SELECT pr.idPunto, denominacion, DiasYHorarios, espacio, direccion, p.idPersona, nombre, apellido, DNI, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                "INNER JOIN Personas p ON pp.idPersona=p.idPersona;";
            
            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable PersonaPunto(string parametro)
        {
            sentencia = "SELECT pr.idPunto, denominacion, DiasYHorarios, espacio, direccion,  p.idPersona,nombre, apellido, DNI, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                $"INNER JOIN Personas p ON pp.idPersona=p.idPersona WHERE denominacion LIKE '%{parametro}%' OR " +
                $" espacio LIKE '%{parametro}%' OR direccion LIKE '%{parametro}%' OR nombre LIKE '%{parametro}%' OR " +
                $"apellido LIKE '%{parametro}%' OR DNI LIKE '%{parametro}%' OR Telefono LIKE '%{parametro}%' " +
                $"OR responsabilidad LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable PersonaPunto(int parametro)
        {
            sentencia = "SELECT pr.idPunto, denominacion, DiasYHorarios, espacio, direccion, p.idPersona, nombre, apellido, DNI, Telefono, " +
                "responsabilidad FROM (PersonaPunto pp INNER JOIN PuntoReciclado pr ON pr.idPunto=pp.idPunto) " +
                $"INNER JOIN Personas p ON pp.idPersona=p.idPersona WHERE p.idPersona LIKE '%{parametro}%' OR " +
                $" pr.idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Punto(string parametro)
        {
            sentencia = $"SELECT * FROM PuntoReciclado WHERE denominacion LIKE '%{parametro}%'" +
                $"OR espacio LIKE '%{parametro}%' OR direccion LIKE '%{parametro}%' ;";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Punto(int parametro)
        {
            sentencia = $"SELECT * FROM PuntoReciclado WHERE idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Punto()
        {
            sentencia = $"SELECT * FROM PuntoReciclado;";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Persona(string parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE nombre LIKE '%{parametro}%' OR apellido LIKE '%{parametro}%'" +
                $" OR DNI LIKE '%{parametro}%' OR Telefono LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Persona(int parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE WHERE idPersona LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        public DataTable Persona()
        {
            sentencia = $"SELECT * FROM Personas;";

            return new CDEjecutarReader().Reader(sentencia);
        }
    }
}
