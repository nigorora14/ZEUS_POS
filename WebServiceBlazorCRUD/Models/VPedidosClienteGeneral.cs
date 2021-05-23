using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VPedidosClienteGeneral
    {
        public string IdPed { get; set; }
        public float? SubTotal { get; set; }
        public float? TotalPed { get; set; }
        public DateTime? FechaPed { get; set; }
        public string EstadoPed { get; set; }
        public float? TotalGancia { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string EstadoCli { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
    }
}
