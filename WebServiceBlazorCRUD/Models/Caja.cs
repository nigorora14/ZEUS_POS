using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class Caja
    {
        public int Idcaja { get; set; }
        public DateTime? FechaCaja { get; set; }
        public string TipoCaja { get; set; }
        public string Concepto { get; set; }
        public string DePara { get; set; }
        public string NroDoc { get; set; }
        public float? ImporteCaja { get; set; }
        public string IdUsu { get; set; }
        public float? TotalUti { get; set; }
        public string TipoPago { get; set; }
        public string GeneradoPor { get; set; }
        public string EstadoCaja { get; set; }
    }
}
