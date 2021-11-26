using System.Data;
using Datos;

namespace Logica
{
    public class CLBuscar
    {

        CDBuscar cDBuscar = new CDBuscar();

        #region ATRIBUTOS
        public string Palabra { private get; set; }
        public string IDPersona { private get; set; }
        public string IDPunto { private get; set; }
        #endregion

        #region RESPONSABILIDADES

        public DataTable Responsabilidades(string Palabra)
        {
            if(Palabra != "")
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Responsabilidades(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Responsabilidades(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Responsabilidades())
                {
                    return DT;
                }
            }
        }
        public DataTable Responsabilidades()
        {
            using (DataTable DT = cDBuscar.Responsabilidades())
                {
                    return DT;
            }
            
        }
        public string ResponsabilidadesScalar()
        {
            if (IDPersona != string.Empty && IDPunto != string.Empty)
            {
                if (int.TryParse(IDPersona, out int idPersonas) && int.TryParse(IDPunto, out int idPunto))
                {
                    return cDBuscar.ResponsabilidadesScalar(idPersonas,idPunto, Palabra).ToString();
                }
                else return "0";
            }
            else return "0";
        }
        #endregion

        #region PUNTOS

        public DataTable Puntos ()
        {
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Puntos(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Puntos(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Puntos())
                {
                    return DT;
                }
            }
        }
        
        public string PuntosScalar()
        {
            if (IDPunto != string.Empty)
            {
                if (int.TryParse(IDPunto, out int idPunto))
                {
                    return cDBuscar.PuntosScalar(idPunto).ToString();
                }
                else return "0";
            }
            else return "0";
        }

        #endregion

        #region PERSONAS

        public DataTable Personas()
        {
            if (Palabra != string.Empty)
            {
                if (int.TryParse(Palabra, out int numero))
                {
                    using (DataTable DT = cDBuscar.Personas(numero))
                    {
                        return DT;
                    }
                }
                else
                {
                    using (DataTable DT = cDBuscar.Personas(Palabra))
                    {
                        return DT;
                    }
                }
            }
            else
            {
                using (DataTable DT = cDBuscar.Personas())
                {
                    return DT;
                }
            }
        }

        public string PersonasScalar()
        {
            if (IDPersona != string.Empty)
            {
                if (int.TryParse(IDPersona, out int idPersonas))
                {
                    return cDBuscar.PersonasScalar(idPersonas).ToString();
                }
                else return "0";
            }
            else return "0";
        }

        #endregion
    }
}
