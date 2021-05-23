using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VKardexDetallePrint
    {
        public double? Entrada { get; set; }
        public double? Salida { get; set; }
        public double? Saldo { get; set; }
        public string DescripcionLarga { get; set; }
        public string UndMedida { get; set; }
        public float PrecioCompra { get; set; }
        public string IdPro { get; set; }
        public double? CostoEntrada { get; set; }
        public double? CostoSalida { get; set; }
        public double? CostoSaldo { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
