using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class GastoInsumo
    {
        public string NombreProducto { get; set; }
        public decimal CostoProducto { get; set; }
        public decimal TotalProductos { get; set; }

        public GastoInsumo()
        {
        }

        public GastoInsumo(string nombreProducto, decimal costoProducto, decimal totalProductos)
        {
            NombreProducto = nombreProducto;
            CostoProducto = costoProducto;
            TotalProductos = totalProductos;
        }
    }
}
