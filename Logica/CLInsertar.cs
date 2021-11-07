using Datos;

namespace Logica
{
    public class CLInsertar
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

        public bool Responsabilidades()
        {
            if (int.TryParse(IDPunto, out int iDPunto) && int.TryParse(IDPersona, out int iDPersona)
                && IDPersona != string.Empty && IDPunto != string.Empty)
            {
                CDInsertar cDInsertar = new CDInsertar
                {
                    IDPersona = iDPersona,
                    IDPunto = iDPunto,
                    Responsabilidad = Responsabilidad
                };
                if (cDInsertar.Responsabilidades()) return true;
                else return false;
            }
            else return false;
        }

        public bool Puntos()
        {
            CDInsertar cDInsertar = new CDInsertar
            {
                Denominacion = Denominacion,
                DiasYHorarios = DiasYHorarios,
                Espacio = Espacio,
                Direccion = Direccion
            };
            if (cDInsertar.Puntos()) return true;
            else return false;
        }

        public bool Personas()
        {
            CDInsertar cDInsertar = new CDInsertar
            {
                Nombre = Nombre,
                Apellido = Apellido,
                DNI = DNI,
                Telefono = Telefono
            };
            if (cDInsertar.Personas()) return true;
            else return false;
        }
    }
}
