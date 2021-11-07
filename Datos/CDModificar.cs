
namespace Datos
{
    public class CDModificar
    {
        public int IDPersona { private get; set; }
        public int IDPunto { private get; set; }
        public string Telefono { private get; set; }
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public string DNI { private get; set; }
        public string Denominacion { private get; set; }
        public string DiasYHorarios { private get; set; }
        public string Espacio { private get; set; }
        public string Direccion { private get; set; }
        public string Responsabilidad { private get; set; }

        public bool Responsabilidades()
        {
            string sentencia = $"UPDATE Responsabilidades SET RESPONSABILIDAD = '{Responsabilidad}' WHERE  idPersona= {IDPersona}" +
                $"AND idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }

        public bool Personas()
        {
            string sentencia = $"UPDATE Personas SET NOMBRE = '{Nombre}', APELLIDO = '{Apellido}', DNI = '{DNI}', TELEFONO = '{Telefono}' " +
                $"WHERE idPersona= {IDPersona};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }

        public bool Puntos()
        {
            string sentencia = $"UPDATE Puntos SET DENOMINACION = '{Denominacion}', DIASYHORARIOS = '{DiasYHorarios}', ESPACIO= '{Espacio}'," +
                $" DIRECCION = '{Direccion}' WHERE idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
    }
}
