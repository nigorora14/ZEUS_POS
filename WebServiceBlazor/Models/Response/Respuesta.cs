using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceBlazor.Models.Response
{
    public class Respuesta
    {
        public int exito { get; set; }
        public string Mensaje { get; set; }
        public object Data { get; set; }
        //constructor
        public Respuesta()
        {
            this.exito = 0;
        }
    }
}
