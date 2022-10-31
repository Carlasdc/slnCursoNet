using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal Margen { get; set; }
        public decimal IVA { get; set; }
        public decimal PrecioBruto { get
            {
                decimal _PrecioBruto = 0;
                {
                    _PrecioBruto = this.PrecioCosto + this.IVA;
                }
                return _PrecioBruto;
            }
        }
        public decimal PrecioVenta { get
            {
                decimal _PrecioVenta = 0;
                {
                    _PrecioVenta = this.PrecioBruto + this.Margen;
                }
            return _PrecioVenta;
            }
        }

        public string Categoria { get; set; }
        public string Subcategorias { get; set; }

    }
}
