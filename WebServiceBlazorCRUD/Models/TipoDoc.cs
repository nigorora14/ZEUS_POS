using System;
using System.Collections.Generic;

#nullable disable

namespace WebServiceBlazorCRUD.Models
{
    public partial class TipoDoc
    {
        public TipoDoc()
        {
            Documentos = new HashSet<Documento>();
        }

        public int IdTipo { get; set; }
        public string Documento { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string EstadoTiDoc { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
