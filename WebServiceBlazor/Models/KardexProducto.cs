using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazor.Models
{
    public partial class KardexProducto
    {
        public string IdKrdx { get; set; }
        public string IdPro { get; set; }
        public string Idprovee { get; set; }
        public DateTime? FechaCre { get; set; }
        public string EstadoKrdx { get; set; }

        public virtual Producto IdProNavigation { get; set; }
    }
}
