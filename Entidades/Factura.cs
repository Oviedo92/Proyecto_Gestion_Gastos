using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Factura
    {
        public string Codigo { get; set; }
        public string MesFactura { get; set; }
        public string AñoFactura { get; set; }
        public Empleado EmpladoFactura { get; set; }

        public Factura()
        {
        }

        public Factura(string codigo, string mesFactura, string añoFactura, Empleado empladoFactura)
        {
            Codigo = codigo;
            MesFactura = mesFactura;
            AñoFactura = añoFactura;
            EmpladoFactura = empladoFactura;
        }
    }
}
