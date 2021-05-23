using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class VVistaCotizacionPedidoDetalle
    {
        public string IdCotiza { get; set; }
        public DateTime? FechaCoti { get; set; }
        public float? TotalCotiza { get; set; }
        public string EstadoCoti { get; set; }
        public int? Vigencia { get; set; }
        public string Condiciones { get; set; }
        public string IdPed { get; set; }
        public string EstadoPed { get; set; }
        public float? TotalGancia { get; set; }
        public float? SubTotal { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public float? Cantidad { get; set; }
        public string UndMedida { get; set; }
        public float? PrecioConIgv { get; set; }
        public float? ImporteConIgv { get; set; }
        public float? UtilidadUnit { get; set; }
        public float? TotalUtilidad { get; set; }
        public string TipoProd { get; set; }
        public string IdPro { get; set; }
        public string DescripcionLarga { get; set; }
        public float StockActual { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }
}
