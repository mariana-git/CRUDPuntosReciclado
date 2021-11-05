using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Datos
{
    public class CDInsertar
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


        public bool Personas()
        {
            string sentencia = $"INSERT INTO Personas (nombre, apellido, DNI, Telefono) VALUES ('{Nombre}', '{Apellido}', '{DNI}', '{Telefono}');";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool PuntoReciclado()
        {
            string sentencia = $"INSERT INTO PuntoReciclado (denominacion, DiasYHorarios, espacio, direccion) VALUES ('{Denominacion}', '{DiasYHorarios}', '{Espacio}', '{Direccion}');";

            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }
        public bool PersonaPunto()
        {
            string sentencia = $"INSERT INTO PersonaPunto VALUES ({IDPersona}, {IDPunto}, '{Responsabilidad}');";

            if (new CDEjecutarNonQuery().NonQuery(sentencia)==1) return true;
            else return false;
        }
    }
}