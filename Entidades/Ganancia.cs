using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Ganancia
    {
        public string MesGanancia { get; set; }
        public string AñoGanancia { get; set; }

        public GastoTotalMensual GastoTotalMes { get; set; }

        public decimal IngresosMensual{ get; set; }

        public decimal TotalGanancia { get; set; }

        public Ganancia()
        {
        }

        public Ganancia(string mesGanancia, string añoGanancia, GastoTotalMensual gastoTotalMes, decimal ingresosMensual, decimal totalGanancia)
        {
            MesGanancia = mesGanancia;
            AñoGanancia = añoGanancia;
            GastoTotalMes = gastoTotalMes;
            IngresosMensual = ingresosMensual;
            TotalGanancia = totalGanancia;
        }
    }
}
