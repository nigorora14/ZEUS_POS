using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class DetalleNotaCredito
    {
        public string IdCre { get; set; }
        public float? CantidadC { get; set; }
        public string IdPro { get; set; }
        public float? PrecioUniC { get; set; }
        public float? ImporteC { get; set; }
        public string TipoProdctonc { get; set; }
        public string DetalleNotaCredi { get; set; }
        public float CantOrigen { get; set; }

        public virtual NotaCredito IdCreNavigation { get; set; }
    }
}
