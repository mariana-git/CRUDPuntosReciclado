
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
        public bool PersonaPunto()
        {
            string sentencia = $"UPDATE PersonaPunto SET responsabilidad = '{Responsabilidad}' WHERE idPersona= {IDPersona} AND idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool Personas()
        {
            string sentencia = $"UPDATE Personas SET nombre = '{Nombre}', apellido = '{Apellido}', DNI = '{DNI}', Telefono = '{Telefono}' " +
                $"WHERE idPersona= {IDPersona};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool PuntoReciclado()
        {
            string sentencia = $"UPDATE PuntoReciclado SET denominacion = '{Denominacion}', DiasYHorarios = '{DiasYHorarios}', espacio= '{Espacio}'," +
                $" direccion = '{Direccion}' WHERE idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
    }
}
