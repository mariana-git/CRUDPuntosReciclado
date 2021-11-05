namespace Datos
{
    public class CDEliminar
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
            string sentencia = $"DELETE FROM PersonaPunto WHERE idPersona= {IDPersona} AND idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool Personas()
        {
            string sentencia = $"DELETE FROM Personas WHERE idPersona= {IDPersona};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool PuntoReciclado()
        {
            string sentencia = $"DELETE FROM PuntoReciclado WHERE idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }

    }
}
