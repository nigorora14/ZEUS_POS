using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_Blazor.Data
{
    public class Respuesta<T>
    {
        public int exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }
       
    }
}
