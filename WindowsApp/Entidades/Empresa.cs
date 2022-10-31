﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Empresa
    {
        #region constructor
        public Empresa(string nombre, string cuit, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cuit;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        #endregion 

        #region propiedades
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion
    }
}
