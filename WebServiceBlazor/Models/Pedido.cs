using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Cotizacions = new HashSet<Cotizacion>();
            Documentos = new HashSet<Documento>();
        }

        public string IdPed { get; set; }
        public string IdCliente { get; set; }
        public DateTime? FechaPed { get; set; }
        public float? SubTotal { get; set; }
        public float? IgvPed { get; set; }
        public float? TotalPed { get; set; }
        public string IdUsuario { get; set; }
        public float? TotalGancia { get; set; }
        public string EstadoPed { get; set; }
        public float? SubtotalGravado { get; set; }
        public float? IgvGravado { get; set; }
        public float? TotalGravado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<Cotizacion> Cotizacions { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
