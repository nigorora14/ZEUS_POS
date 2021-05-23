using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class ValeCompra
    {
        public string IdVale { get; set; }
        public string IdCliente { get; set; }
        public string NroDoc { get; set; }
        public float? ImporteVale { get; set; }
        public string DetalleVale { get; set; }
        public string EstadoVale { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
