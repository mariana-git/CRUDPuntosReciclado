using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
    public class CLEliminar
    {
        public string IDPersona { private get; set; }
        public string IDPunto { private get; set; }

        public bool PersonaPunto()
        {
            if (int.TryParse(IDPunto, out int iDPunto) && int.TryParse(IDPersona, out int iDPersona))
            {
                CDEliminar cDEliminar = new CDEliminar
                {
                    IDPersona = iDPersona,
                    IDPunto = iDPunto
                };
                if (cDEliminar.PersonaPunto()) return true;
                else return false;
            }
            else return false;
        }
    }
}
