using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class VCajaUsuario
    {
        public int Idcaja { get; set; }
        public DateTime? FechaCaja { get; set; }
        public string TipoCaja { get; set; }
        public string Concepto { get; set; }
        public string DePara { get; set; }
        public string NroDoc { get; set; }
        public float? ImporteCaja { get; set; }
        public string TipoPago { get; set; }
        public float? TotalUti { get; set; }
        public string EstadoCaja { get; set; }
        public string GeneradoPor { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
    }
}
