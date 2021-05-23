using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class Documento
    {
        public Documento()
        {
            Creditos = new HashSet<Credito>();
            NotaCreditos = new HashSet<NotaCredito>();
        }

        public string IdDoc { get; set; }
        public string IdPed { get; set; }
        public int IdTipo { get; set; }
        public DateTime? FechaEmi { get; set; }
        public float ImporteDoc { get; set; }
        public string TipoPago { get; set; }
        public string NroOperacion { get; set; }
        public string IdUsu { get; set; }
        public float? IgvDoc { get; set; }
        public string TotalLetra { get; set; }
        public float? TotalGanancia { get; set; }
        public string EstadoDoc { get; set; }
        public string CdrSunat { get; set; }
        public string HashCpe { get; set; }
        public string EstadoBajada { get; set; }
        public string NroTicketBaja { get; set; }
        public string HashCpeBaja { get; set; }

        public virtual Pedido IdPedNavigation { get; set; }
        public virtual TipoDoc IdTipoNavigation { get; set; }
        public virtual ICollection<Credito> Creditos { get; set; }
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
    }
}
