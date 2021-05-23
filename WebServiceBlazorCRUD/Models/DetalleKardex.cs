using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class DetalleKardex
    {
        public string IdKrdx { get; set; }
        public int Item { get; set; }
        public DateTime FechaKrdx { get; set; }
        public string DocSoporte { get; set; }
        public string DetOperacion { get; set; }
        public float? CantidadIn { get; set; }
        public float? PrecioIn { get; set; }
        public float? TotalIn { get; set; }
        public float? CantidadOut { get; set; }
        public float? PrecioOut { get; set; }
        public float? TotalOut { get; set; }
        public float? CantidadSaldo { get; set; }
        public float? Promedio { get; set; }
        public float? CostoTotalSaldo { get; set; }

        public virtual KardexProducto IdKrdxNavigation { get; set; }
    }
}
