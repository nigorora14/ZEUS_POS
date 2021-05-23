﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_POSFE.Models
{
    public partial class VIstaNotacreditoGnral
    {
        public string IdCre { get; set; }
        public string IdDoc { get; set; }
        public string Tipocomprobnte { get; set; }
        public string OtrosDatos { get; set; }
        public DateTime FechaEmision { get; set; }
        public float VlrTotal { get; set; }
        public float? IgvC { get; set; }
        public float? SubTotalC { get; set; }
        public string MotivoEmis { get; set; }
        public string EstadoCr { get; set; }
        public string SonCre { get; set; }
        public string EstadoDinero { get; set; }
        public string NcEnviadoSunat { get; set; }
        public string CdrSunatNotaCre { get; set; }
        public string HashCpeNotaCre { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string UbicacionFoto { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
    }
}
