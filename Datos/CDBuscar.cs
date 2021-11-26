using System.Data;

namespace Datos
{
    public class CDBuscar
    {
        private string sentencia;

        #region RESPONSABILIDADES

        public DataTable Responsabilidades()
        {
            return new CDEjecutarReader().ReaderSP("spResponsabilidades_Leer");
        }

        public DataTable Responsabilidades(string parametro)
        {
            return new CDEjecutarReader().ReaderSP("spResponsabilidades_BuscarString",parametro);
        }

        public DataTable Responsabilidades(int parametro)
        {
            return new CDEjecutarReader().ReaderSP("spResponsabilidades_BuscarInt", parametro);
        }

        public int ResponsabilidadesScalar(int idPersona, int idPunto, string responsabilidad)
        {
            sentencia = $"SELECT COUNT(*) FROM Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto = r.idPunto"+
                        $" INNER JOIN Personas p ON r.idPersona = p.idPersona WHERE r.idPersona = {idPersona} AND " +
                        $"r.idPunto = {idPunto} AND RESPONSABILIDAD = '{responsabilidad}'";
            return new CDEjecutarScalar().ScalarQ(sentencia);
        }

        #endregion

        #region PUNTOS

        public DataTable Puntos(string parametro)
        {
            sentencia = $"SELECT * FROM Puntos WHERE DENOMINACION LIKE '%{parametro}%'" +
                $"OR ESPACIO LIKE '%{parametro}%' OR DIRECCION LIKE '%{parametro}%' ;";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public DataTable Puntos(int parametro)
        {
            sentencia = $"SELECT * FROM Puntos WHERE idPunto LIKE '%{parametro}%';";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public DataTable Puntos()
        {
            sentencia = $"SELECT * FROM Puntos;";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public int PuntosScalar(int idPunto)
        {
            sentencia = "SELECT COUNT(*) FROM Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto = r.idPunto " +
                $"INNER JOIN Personas p ON r.idPersona=p.idPersona WHERE r.idPunto = {idPunto} ; ";

            return new CDEjecutarScalar().ScalarQ(sentencia);
        }
        #endregion

        #region PERSONAS

        public DataTable Personas(string parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE NOMBRE LIKE '%{parametro}%' OR APELLIDO LIKE '%{parametro}%';";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public DataTable Personas(int parametro)
        {
            sentencia = $"SELECT * FROM Personas WHERE idPersona LIKE '%{parametro}%';";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public DataTable Personas()
        {
            sentencia = $"SELECT * FROM Personas;";

            return new CDEjecutarReader().ReaderQ(sentencia);
        }

        public int PersonasScalar(int idPersona)
        {
            sentencia = "SELECT COUNT(*) FROM Responsabilidades r INNER JOIN Puntos pr ON pr.idPunto = r.idPunto " +
                $"INNER JOIN Personas p ON r.idPersona=p.idPersona WHERE r.idPersona = {idPersona} ; ";

            return new CDEjecutarScalar().ScalarQ(sentencia);
        }
        #endregion
    }
}
