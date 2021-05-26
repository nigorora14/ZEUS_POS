using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceBlazor.Models.Response
{
    public class Respuesta<T>
    {
        public int exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }//va devolver una lista
        //constructor
        public Respuesta()
        {
            this.exito = 0;
        }
    }
}
