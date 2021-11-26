using Datos;

namespace Logica
{
    public class CLModificar
    {
        #region ATRIBUTOS
        public string IDPersona { private get; set; }
        public string IDPunto { private get; set; }
        public string Nombre { private get; set; }
        public string Apellido { private get; set; }
        public string DNI { private get; set; }
        public string Telefono { private get; set; }
        public string Denominacion { private get; set; }
        public string DiasYHorarios { private get; set; }
        public string Espacio { private get; set; }
        public string Direccion { private get; set; }
        public string Responsabilidad { private get; set; }
        #endregion

        public bool Puntos()
        {
            if (int.TryParse(IDPunto, out int iDPunto))
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPunto = iDPunto,
                    Denominacion = Denominacion,
                    DiasYHorarios = DiasYHorarios,
                    Espacio = Espacio,
                    Direccion = Direccion
                };
                if (cDModificar.Puntos()) return true;
                else return false;
            }
            else return false;
        }

        public bool Personas()
        {
            if (int.TryParse(IDPersona, out int iDPersona) && int.TryParse(Telefono, out int telefono) && int.TryParse(DNI, out int dni))
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPersona = iDPersona,                    
                    Nombre = Nombre,
                    Apellido = Apellido,
                    DNI = dni,
                    Telefono = telefono                   
                };
                if (cDModificar.Personas()) return true;
                else return false;
            }
            else return false;
        }

        public bool Responsabilidades()
        {
            if (int.TryParse(IDPunto, out int iDPunto) && int.TryParse(IDPersona, out int iDPersona))
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPersona = iDPersona,
                    IDPunto = iDPunto,
                    Responsabilidad = Responsabilidad
                };
                if (cDModificar.Responsabilidades()) return true;
                else return false;
            }
            else return false;
        }
    }
}
