using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Factura:DocumentoComercial
    {
        #region constructor
        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicioniva, string condicionventa, string detalle, decimal total): base( numero, fecha, cliente, direccion, condicioniva, condicionventa, detalle)
        {
            Tipo = tipo;
            Total = total;
        }
        #endregion
        #region propiedades
        public string Tipo { get; set; }
        public decimal Total { get; set; }
        #endregion
    }
}
