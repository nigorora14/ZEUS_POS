using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VDocumentosCompraDetalle
    {
        public string IdDocComp { get; set; }
        public string NroFacFisico { get; set; }
        public float? SubTotalIngre { get; set; }
        public DateTime? FechaIngre { get; set; }
        public float TotalIngre { get; set; }
        public string ModalidadPago { get; set; }
        public int? TiempoEspera { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string EstadoIngre { get; set; }
        public bool? Recibiconforme { get; set; }
        public string DatosAdicional { get; set; }
        public string TipoDocCompra { get; set; }
        public string Idprovee { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public float? PrecioUnit { get; set; }
        public float? Cantidad { get; set; }
        public float? Importe { get; set; }
        public string IdPro { get; set; }
        public string DescripcionLarga { get; set; }
        public float StockActual { get; set; }
        public float PreCompra { get; set; }
        public float PreCompraS { get; set; }
    }
}
