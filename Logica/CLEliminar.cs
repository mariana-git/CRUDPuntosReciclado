using Datos;

namespace Logica
{
    public class CLEliminar
    {
        public string IDPersona { private get; set; }
        public string IDPunto { private get; set; }

        public bool Responsabilidades()
        {
            if (int.TryParse(IDPersona, out int iDPersona) && int.TryParse(IDPunto, out int iDPunto))
            {
                CDEliminar cDEliminar = new CDEliminar
                {
                    IDPersona = iDPersona,
                    IDPunto = iDPunto
                };
                if (cDEliminar.Responsabilidades()) return true;
                else return false;
            }
            else return false;
        }

        public bool Personas()
        {
            if ( int.TryParse(IDPersona, out int iDPersona))
            {
                CDEliminar cDEliminar = new CDEliminar
                {
                    IDPersona = iDPersona
                };
                if (cDEliminar.Personas()) return true;
                else return false;
            }
            else return false;
        }

        public bool Puntos()
        {
            if (int.TryParse(IDPunto, out int iDPunto))
            {
                CDEliminar cDEliminar = new CDEliminar
                {
                    IDPunto = iDPunto
                };
                if (cDEliminar.Puntos()) return true;
                else return false;
            }
            else return false;
        }
    }
}
