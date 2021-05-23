using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class VUsuariosRoles2
    {
        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Usuario { get; set; }
        public byte[] Contraseña { get; set; }
        public string UbicacionFoto { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string EstadoUsu { get; set; }
    }
}
