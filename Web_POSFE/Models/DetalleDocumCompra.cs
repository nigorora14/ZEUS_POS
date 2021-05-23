using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class DetalleDocumCompra
    {
        public string IdDocComp { get; set; }
        public string IdPro { get; set; }
        public float? PrecioUnit { get; set; }
        public float? Cantidad { get; set; }
        public float? Importe { get; set; }

        public virtual DocumentoCompra IdDocCompNavigation { get; set; }
        public virtual Producto IdProNavigation { get; set; }
    }
}
