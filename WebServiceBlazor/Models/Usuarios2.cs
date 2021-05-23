using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class Usuarios2
    {
        public Usuarios2()
        {
            NotaCreditos = new HashSet<NotaCredito>();
        }

        public string IdUsu { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdDis { get; set; }
        public string Usuario { get; set; }
        public byte[] Contraseña { get; set; }
        public string UbicacionFoto { get; set; }
        public DateTime FechaNcmiento { get; set; }
        public int IdRol { get; set; }
        public string Correo { get; set; }
        public string EstadoUsu { get; set; }
        public byte[] Salt { get; set; }

        public virtual ICollection<NotaCredito> NotaCreditos { get; set; }
    }
}
