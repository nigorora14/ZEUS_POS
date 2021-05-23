using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class VDocumentoCreditoYDetalle
    {
        public string IdNotaCred { get; set; }
        public DateTime? FechaCredito { get; set; }
        public string NomCliente { get; set; }
        public float? TotalCre { get; set; }
        public float? SaldoPdnte { get; set; }
        public DateTime? FechaVncimnto { get; set; }
        public string EstadoCred { get; set; }
        public string IdDoc { get; set; }
        public DateTime? FechaEmi { get; set; }
        public float ImporteDoc { get; set; }
        public string EstadoDoc { get; set; }
        public string IdUsu { get; set; }
        public string IdPed { get; set; }
        public float? TotalGancia { get; set; }
        public float? TotalPed { get; set; }
        public string EstadoPed { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public float? LimitCredit { get; set; }
        public string Dni { get; set; }
        public DateTime? FechaPago { get; set; }
        public float? SaldoActual { get; set; }
        public float ACuenta { get; set; }
        public string NroOperaComent { get; set; }
    }
}
