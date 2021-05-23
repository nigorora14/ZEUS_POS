using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VTemporalesDetalle
    {
        public string CodTem { get; set; }
        public string FechaEmi { get; set; }
        public string Cliente { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string SubTtal { get; set; }
        public string IgvT { get; set; }
        public string TotalT { get; set; }
        public string SonT { get; set; }
        public string Vendedor { get; set; }
        public byte[] CodigoQr { get; set; }
        public string CodPro { get; set; }
        public string Producto { get; set; }
        public string PreUnt { get; set; }
        public string ImporteT { get; set; }
        public string Cantidad { get; set; }
        public string TipoComprobante { get; set; }
        public string HashCpe { get; set; }
        public string TipoPago { get; set; }
        public string MotivoEmis { get; set; }
    }
}
