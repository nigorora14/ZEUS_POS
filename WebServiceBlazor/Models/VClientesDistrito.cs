using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class VClientesDistrito
    {
        public string IdCliente { get; set; }
        public string RazonSocialNombres { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public int IdDis { get; set; }
        public string Distrito { get; set; }
        public DateTime? FchaNcmntoAnivsrio { get; set; }
        public string Contacto { get; set; }
        public float? LimitCredit { get; set; }
        public string EstadoCli { get; set; }
    }
}
