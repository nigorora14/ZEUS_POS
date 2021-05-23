using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VKardexDetalle
    {
        public string IdKrdx { get; set; }
        public string EstadoKrdx { get; set; }
        public string Idprovee { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
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
        public string IdPro { get; set; }
        public string DescripcionLarga { get; set; }
        public float StockActual { get; set; }
    }
}
