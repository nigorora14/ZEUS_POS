using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class DocumentoCompra
    {
        public string IdDocComp { get; set; }
        public string NroFacFisico { get; set; }
        public string Idprovee { get; set; }
        public float? SubTotalIngre { get; set; }
        public DateTime? FechaIngre { get; set; }
        public float TotalIngre { get; set; }
        public string IdUsu { get; set; }
        public string ModalidadPago { get; set; }
        public int? TiempoEspera { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string EstadoIngre { get; set; }
        public bool? Recibiconforme { get; set; }
        public string DatosAdicional { get; set; }
        public string TipoDocCompra { get; set; }
        public string TipoIngreso { get; set; }
    }
}
