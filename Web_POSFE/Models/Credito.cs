using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class Credito
    {
        public Credito()
        {
            DetalleCreditos = new HashSet<DetalleCredito>();
        }

        public string IdNotaCred { get; set; }
        public string IdDoc { get; set; }
        public DateTime FechaCredito { get; set; }
        public string NomCliente { get; set; }
        public float? TotalCre { get; set; }
        public float? SaldoPdnte { get; set; }
        public DateTime? FechaVncimnto { get; set; }
        public string EstadoCred { get; set; }

        public virtual Documento IdDocNavigation { get; set; }
        public virtual ICollection<DetalleCredito> DetalleCreditos { get; set; }
    }
}
