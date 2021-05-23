using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class DetallePedido
    {
        public string IdPed { get; set; }
        public string IdPro { get; set; }
        public float? PrecioConIgv { get; set; }
        public float? Cantidad { get; set; }
        public float? ImporteConIgv { get; set; }
        public string TipoProd { get; set; }
        public string UndMedida { get; set; }
        public float? UtilidadUnit { get; set; }
        public float? TotalUtilidad { get; set; }
        public string AfectoIgv { get; set; }
        public float? PrecioSinIgv { get; set; }
        public float? SubtotalSinIgv { get; set; }
        public float? IgvSubtotal { get; set; }
        public string Estado { get; set; }
        public float PCantOriginal { get; set; }

        public virtual Producto IdProNavigation { get; set; }
    }
}
