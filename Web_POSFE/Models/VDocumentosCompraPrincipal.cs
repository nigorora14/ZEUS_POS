using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class VDocumentosCompraPrincipal
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
        public string TipoIngreso { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public string UbicacionFoto { get; set; }
    }
}
