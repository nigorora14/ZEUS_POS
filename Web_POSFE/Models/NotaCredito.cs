using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class NotaCredito
    {
        public string IdCre { get; set; }
        public string IdDoc { get; set; }
        public string Tipocomprobnte { get; set; }
        public string OtrosDatos { get; set; }
        public DateTime FechaEmision { get; set; }
        public float VlrTotal { get; set; }
        public float? IgvC { get; set; }
        public float? SubTotalC { get; set; }
        public string IdUsu { get; set; }
        public string MotivoEmis { get; set; }
        public string EstadoCr { get; set; }
        public string SonCre { get; set; }
        public string EstadoDinero { get; set; }
        public string IdCliente { get; set; }
        public string CdrSunatNotaCre { get; set; }
        public string HashCpeNotaCre { get; set; }
        public string NcEnviadoSunat { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Documento IdDocNavigation { get; set; }
        public virtual Usuarios2 IdUsuNavigation { get; set; }
    }
}
