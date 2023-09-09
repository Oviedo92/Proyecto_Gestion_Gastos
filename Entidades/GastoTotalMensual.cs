using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class GastoTotalMensual
    {
        public string GastoTotalMes { get; set; }
        public string GastoTotalAño { get; set; }
        public Empleado GastoTotalSueldo { get; set; }
        public LiquidacionMensual GastoTotalLiquidacion { get; set; }

        public GastoInsumo GastoTotalInsumo { get; set; }

        public decimal GastoTotal { get ; set; }

        public GastoTotalMensual()
        {
        }

        public GastoTotalMensual(string gastoTotalMes, string gastoTotalAño, Empleado gastoTotalSueldo, LiquidacionMensual gastoTotalLiquidacion, GastoInsumo gastoTotalInsumo, decimal gastoTotal)
        {
            GastoTotalMes = gastoTotalMes;
            GastoTotalAño = gastoTotalAño;
            GastoTotalSueldo = gastoTotalSueldo;
            GastoTotalLiquidacion = gastoTotalLiquidacion;
            GastoTotalInsumo = gastoTotalInsumo;
            GastoTotal = gastoTotal;
        }
    }
}
