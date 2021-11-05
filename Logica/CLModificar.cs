﻿using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CLModificar
    {

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

        public bool Puntos()
        {
            if (IDPunto != string.Empty && int.TryParse(IDPunto, out int iDPunto))
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPunto = iDPunto,
                    Denominacion = Denominacion,
                    DiasYHorarios = DiasYHorarios,
                    Espacio = Espacio,
                    Direccion = Direccion
                };
                if (cDModificar.PuntoReciclado()) return true;
                else return false;
            }
            else return false;
        }
        public bool Personas()
        {
            if (IDPersona != string.Empty && int.TryParse(IDPersona, out int iDPersona))
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPersona = iDPersona,                    
                    Nombre = Nombre,
                    Apellido = Apellido,
                    DNI = DNI,
                    Telefono = Telefono                   
                };
                if (cDModificar.Personas()) return true;
                else return false;
            }
            else return false;
        }
        public bool PersonaPunto()
        {
            if (int.TryParse(IDPunto, out int iDPunto) && int.TryParse(IDPersona, out int iDPersona)
                && IDPersona != string.Empty && IDPunto != string.Empty)
            {
                CDModificar cDModificar = new CDModificar
                {
                    IDPersona = iDPersona,
                    IDPunto = iDPunto,                    
                    Responsabilidad = Responsabilidad
                };
                if (cDModificar.PersonaPunto()) return true;
                else return false;
            }
            else return false;
        }
    }
}