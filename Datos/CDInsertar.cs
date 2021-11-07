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
            string sentencia = $"INSERT INTO Personas (NOMBRE, APELLIDO, DNI, TELEFONO) VALUES ('{Nombre}', '{Apellido}', '{DNI}', '{Telefono}');";
            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }

        public bool Puntos()
        {
            string sentencia = $"INSERT INTO Puntos (DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION) VALUES ('{Denominacion}', '{DiasYHorarios}', '{Espacio}', '{Direccion}');";

            if (new CDEjecutarNonQuery().NonQuery(sentencia) == 1) return true;
            else return false;
        }

        public bool Responsabilidades()
        {
            string sentencia = $"INSERT INTO Responsabilidades (idPersona,idPunto, RESPONSABILIDAD) VALUES ({IDPersona}, {IDPunto}, '{Responsabilidad}');";

            if (new CDEjecutarNonQuery().NonQuery(sentencia)==1) return true;
            else return false;
        }
    }
}