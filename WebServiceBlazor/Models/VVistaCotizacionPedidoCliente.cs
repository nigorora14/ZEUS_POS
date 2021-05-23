using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VVistaCotizacionPedidoCliente
    {
        public string IdCotiza { get; set; }
        public DateTime? FechaCoti { get; set; }
        public float? TotalCotiza { get; set; }
        public string EstadoCoti { get; set; }
        public int? Vigencia { get; set; }
        public string PrecioconIgv { get; set; }
        public string Condiciones { get; set; }
        public string IdPed { get; set; }
        public string EstadoPed { get; set; }
        public float? TotalPed { get; set; }
        public float? SubTotal { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
    }
}
