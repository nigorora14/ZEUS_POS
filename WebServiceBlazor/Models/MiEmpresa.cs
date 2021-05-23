using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class MiEmpresa
    {
        public int Idrancho { get; set; }
        public string Nombrerancho { get; set; }
        public string NroRuc { get; set; }
        public string Direccionran { get; set; }
        public string Correo { get; set; }
        public string Clavecorreo { get; set; }
        public string Clavesol { get; set; }
        public string Usuariosol { get; set; }
        public string Clavecertificado { get; set; }
        public string Obs { get; set; }
    }
}
