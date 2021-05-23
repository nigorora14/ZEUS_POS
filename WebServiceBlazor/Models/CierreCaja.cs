using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class CierreCaja
    {
        public string IdCierre { get; set; }
        public DateTime FechaCierre { get; set; }
        public float AperturaCaja { get; set; }
        public float? TotalIngreso { get; set; }
        public float? TotalEgreso { get; set; }
        public string IdUsu { get; set; }
        public float? TodoDeposito { get; set; }
        public float? Gananciadeldia { get; set; }
        public float? TotalEntregado { get; set; }
        public float? SaldoSiguiente { get; set; }
        public float? TotalFactura { get; set; }
        public float? TotalBoleta { get; set; }
        public float? TotalNotaVenta { get; set; }
        public float? TotalCreditoCobrado { get; set; }
        public float? TotalCreditoEmitido { get; set; }
        public string EstadoCierre { get; set; }
    }
}
