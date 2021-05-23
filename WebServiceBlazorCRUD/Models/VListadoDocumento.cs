using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VListadoDocumento
    {
        public DateTime? FechaHora { get; set; }
        public string IdDoc { get; set; }
        public string TipoPago { get; set; }
        public float ImporteDoc { get; set; }
        public DateTime? FechaEmi { get; set; }
        public float? IgvDoc { get; set; }
        public string EstadoDoc { get; set; }
        public string NroOperacion { get; set; }
        public string TotalLetra { get; set; }
        public float? TotalGanancia { get; set; }
        public string CdrSunat { get; set; }
        public string HashCpe { get; set; }
        public string EstadoBajada { get; set; }
        public string NroTicketBaja { get; set; }
        public string HashCpeBaja { get; set; }
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaPed { get; set; }
        public float? SubTotal { get; set; }
        public float? TotalPed { get; set; }
        public string EstadoPed { get; set; }
        public string IdPed { get; set; }
        public float? SubtotalGravado { get; set; }
        public float? IgvGravado { get; set; }
        public float? TotalGravado { get; set; }
        public int IdTipo { get; set; }
        public string Documento { get; set; }
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompletoUsu { get; set; }
    }
}
