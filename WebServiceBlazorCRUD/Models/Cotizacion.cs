using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class Cotizacion
    {
        public string IdCotiza { get; set; }
        public string IdPed { get; set; }
        public DateTime? FechaCoti { get; set; }
        public int? Vigencia { get; set; }
        public float? TotalCotiza { get; set; }
        public string Condiciones { get; set; }
        public string PrecioconIgv { get; set; }
        public string EstadoCoti { get; set; }

        public virtual Pedido IdPedNavigation { get; set; }
    }
}
