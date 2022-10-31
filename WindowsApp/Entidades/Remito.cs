using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Remito:DocumentoComercial
    {
        #region constructor
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicioniva, string condicionventa, string detalle, DateTime fechaentrega, decimal total) : base(numero, fecha, cliente, direccion, condicioniva, condicionventa, detalle)
        {
            FechaEntrega = fechaentrega;
            Total = total;
        }
        #endregion

        #region propiedades
        public DateTime FechaEntrega { get; set; }
        public decimal Total { get; set; }
        #endregion
    }

}
