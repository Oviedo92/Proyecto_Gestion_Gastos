using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Correo { get; set;}
        public string Identificacion { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal SueldoTotal { get; set; }
        public decimal Liquidacion { get; set; }

        public Empleado()
        {
        }

        public Empleado(string nombre, string correo, string identificacion, decimal salarioBase, decimal bonificacion, decimal sueldoTotal, decimal liquidacion)
        {
            Nombre = nombre;
            Correo = correo;
            Identificacion = identificacion;
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
            SueldoTotal = sueldoTotal;
            Liquidacion = liquidacion;
        }
    }
}
