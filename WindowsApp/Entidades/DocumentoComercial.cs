using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public abstract class DocumentoComercial
    {
        #region constructor
        public DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion, string condicioniva, string condicionventa, string detalle)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicioniva;
            CondicionVenta = condicionventa;
            Detalle = detalle;
        }
        #endregion

        #region propiedades
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        #endregion
    }
}
