using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            NotaCreditos = new HashSet<NotaCredito>();
            Pedidos = new HashSet<Pedido>();
            ValeCompras = new HashSet<ValeCompra>();
        }

        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public int IdDis { get; set; }
        public DateTime? FchaNcmntoAnivsrio { get; set; }
        public string Contacto { get; set; }
        public float? LimitCredit { get; set; }
        public string EstadoCli { get; set; }
        public string Foto { get; set; }

        public virtual Distrito IdDisNavigation { get; set; }
        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<ValeCompra> ValeCompras { get; set; }
    }
}
