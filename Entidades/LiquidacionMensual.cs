using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class LiquidacionMensual
    {
 

        public string MesLiquidacion {get; set;}
        public string AñoLiquidacion { get; set;}
        public decimal LiquidacionPorDia { get; set;}
        public int DiasTrabajados { get; set;}
        public Empleado EmpleadoLiquidacion { get; set;}

        public LiquidacionMensual()
        {
        }

        public LiquidacionMensual(string mesLiquidacion, string añoLiquidacion, decimal liquidacionPorDia, int diasTrabajados, Empleado empleadoLiquidacion)
        {
            MesLiquidacion = mesLiquidacion;
            AñoLiquidacion = añoLiquidacion;
            LiquidacionPorDia = liquidacionPorDia;
            DiasTrabajados = diasTrabajados;
            EmpleadoLiquidacion = empleadoLiquidacion;
        }
    }



}
