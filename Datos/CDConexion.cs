﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class CDConexion
    {
        private readonly string cadena;

        public CDConexion() => cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|dbPuntosReciclado.accdb; Persist Security Info=False;";

        protected OleDbConnection Conectar()
        {
            return new OleDbConnection(cadena);
        }
    }
}