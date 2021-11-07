using System.Data;

namespace Datos
{
    public class CDBuscar
    {
        private string sentencia;

        #region RESPONSABILIDADES

        public DataTable Responsabilidades()
        {
            sentencia = "SELECT pr.idPunto, DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION, p.idPersona, NOMBRE, APELLIDO, DNI, TELEFONO, " +
                "RESPONSABILIDAD FROM (Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto = r.idPunto) " +
                "INNER JOIN Personas p ON r.idPersona=p.idPersona;";
            
            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Responsabilidades(string parametro)
        {
            sentencia = "SELECT pr.idPunto,DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION, p.idPersona, NOMBRE, APELLIDO, DNI, TELEFONO,  " +
                "RESPONSABILIDAD FROM (Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto = r.idPunto) " +
                $"INNER JOIN Personas p ON r.idPersona=p.idPersona WHERE denominacion LIKE '%{parametro}%' OR " +
                $" ESPACIO LIKE '%{parametro}%' OR DIRECCION LIKE '%{parametro}%' OR NOMBRE LIKE '%{parametro}%' OR " +
                $"APELLIDO LIKE '%{parametro}%' OR DNI LIKE '%{parametro}%' OR TELEFONO LIKE '%{parametro}%' " +
                $"OR RESPONSABILIDAD LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Responsabilidades(int parametro)
        {
            sentencia = "SELECT pr.idPunto, DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION, p.idPersona, NOMBRE, APELLIDO, DNI, TELEFONO,  " +
                "RESPONSABILIDAD FROM (Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto= r.idPunto) " +
                $"INNER JOIN Personas p ON r.idPersona=p.idPersona WHERE p.idPersona LIKE '%{parametro}%' OR " +
                $" pr.idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }
        #endregion

        #region PUNTOS

        public DataTable Puntos(string parametro)
        {
            sentencia = $"SELECT * FROM Puntos WHERE DENOMINACION LIKE '%{parametro}%'" +
                $"OR ESPACIO LIKE '%{parametro}%' OR DIRECCION LIKE '%{parametro}%' ;";

            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Puntos(int parametro)
        {
            sentencia = $"SELECT * FROM Puntos WHERE idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Puntos()
        {
            sentencia = $"SELECT * FROM Puntos;";

            return new CDEjecutarReader().Reader(sentencia);
        }
        #endregion

        #region PERSONAS

        public DataTable Personas(string parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE NOMBRE LIKE '%{parametro}%' OR APELLIDO LIKE '%{parametro}%'" +
                $" OR DNI LIKE '%{parametro}%' OR TELEFONO LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Personas(int parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE idPersona LIKE '%{parametro}%';";

            return new CDEjecutarReader().Reader(sentencia);
        }

        public DataTable Personas()
        {
            sentencia = $"SELECT * FROM Personas;";

            return new CDEjecutarReader().Reader(sentencia);
        }
        #endregion
    }
}
