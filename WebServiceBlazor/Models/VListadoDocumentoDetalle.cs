using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VListadoDocumentoDetalle
    {
        public string IdDoc { get; set; }
        public string IdPed { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public float ImporteDoc { get; set; }
        public DateTime? FechaPed { get; set; }
        public float? SubTotal { get; set; }
        public float? TotalPed { get; set; }
        public string IdUsuario { get; set; }
        public string EstadoPed { get; set; }
        public float? TotalGancia { get; set; }
        public float? PrecioConIgv { get; set; }
        public float? Cantidad { get; set; }
        public float? ImporteConIgv { get; set; }
        public string UndMedida { get; set; }
        public string TipoProd { get; set; }
        public float? UtilidadUnit { get; set; }
        public float? TotalUtilidad { get; set; }
        public string AfectoIgv { get; set; }
        public float? PrecioSinIgv { get; set; }
        public float? SubtotalSinIgv { get; set; }
        public float? IgvSubtotal { get; set; }
        public string IdPro { get; set; }
        public string DescripcionLarga { get; set; }
        public float StockActual { get; set; }
        public float PCantOriginal { get; set; }
        public string TotalLetra { get; set; }
        public float? IgvDoc { get; set; }
        public string EstadoDoc { get; set; }
        public DateTime? FechaEmi { get; set; }
        public string NroOperacion { get; set; }
        public string TipoPago { get; set; }
        public float? Totalganancia { get; set; }
        public string CdrSunat { get; set; }
        public int IdTipo { get; set; }
        public string Documento { get; set; }
        public string Estado { get; set; }
    }
}
