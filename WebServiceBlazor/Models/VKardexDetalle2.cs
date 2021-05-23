using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VKardexDetalle2
    {
        public int Item { get; set; }
        public DateTime? Fecha { get; set; }
        public string DocSoporte { get; set; }
        public string DetMovimiento { get; set; }
        public float? Entrada { get; set; }
        public float? Salida { get; set; }
        public float? Saldo { get; set; }
        public string DescripcionLarga { get; set; }
        public string UndMedida { get; set; }
        public float PrecioCompra { get; set; }
        public string IdPro { get; set; }
        public double? CostoEntrada { get; set; }
    }
}
