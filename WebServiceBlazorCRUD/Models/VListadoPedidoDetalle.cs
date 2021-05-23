using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VListadoPedidoDetalle
    {
        public string IdPed { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public float? SubTotal { get; set; }
        public DateTime? FechaPed { get; set; }
        public float? TotalPed { get; set; }
        public string EstadoPed { get; set; }
        public float? TotalGancia { get; set; }
        public string IdUsuario { get; set; }
        public float? PrecioConIgv { get; set; }
        public float? Cantidad { get; set; }
        public float? ImporteConIgv { get; set; }
        public string TipoProd { get; set; }
        public string UndMedida { get; set; }
        public float? UtilidadUnit { get; set; }
        public float? TotalUtilidad { get; set; }
        public string DescripcionLarga { get; set; }
        public string IdPro { get; set; }
        public float StockActual { get; set; }
    }
}
