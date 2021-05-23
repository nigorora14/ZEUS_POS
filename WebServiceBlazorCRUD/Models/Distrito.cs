using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdDis { get; set; }
        public string Distrito1 { get; set; }
        public string EstadoDis { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
