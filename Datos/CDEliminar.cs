namespace Datos
{
    public class CDEliminar
    {
        #region ATRIBUTOS
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
        #endregion

        public bool Responsabilidades()
        {
            string sentencia = $"DELETE FROM Responsabilidades WHERE idPunto = {IDPunto} AND idPersona ={IDPersona} ;";
            if (new CDEjecutarNonQuery().NonQueryQ(sentencia) == 1) return true;
            else return false;
        }

        public bool Personas()
        {
            string sentencia = $"DELETE FROM Personas WHERE idPersona= {IDPersona};";
            if (new CDEjecutarNonQuery().NonQueryQ(sentencia) == 1) return true;
            else return false;
        }

        public bool Puntos()
        {
            string sentencia = $"DELETE FROM Puntos WHERE idPunto= {IDPunto};";
            if (new CDEjecutarNonQuery().NonQueryQ(sentencia) == 1) return true;
            else return false;
        }

    }
}
