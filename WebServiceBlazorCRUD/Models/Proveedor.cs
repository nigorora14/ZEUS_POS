using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class Proveedor
    {
        public string Idprovee { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Rubro { get; set; }
        public string Ruc { get; set; }
        public string Correo { get; set; }
        public string Contacto { get; set; }
        public string FotoLogo { get; set; }
        public string EstadoProvdr { get; set; }
    }
}
