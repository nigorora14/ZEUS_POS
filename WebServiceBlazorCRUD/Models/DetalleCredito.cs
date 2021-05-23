using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class DetalleCredito
    {
        public int IdDetCred { get; set; }
        public string IdNotaCred { get; set; }
        public float ACuenta { get; set; }
        public float? SaldoActual { get; set; }
        public DateTime? FechaPago { get; set; }
        public string TipoPago { get; set; }
        public string NroOperaComent { get; set; }
        public string IdUsu { get; set; }

        public virtual Credito IdNotaCredNavigation { get; set; }
    }
}
