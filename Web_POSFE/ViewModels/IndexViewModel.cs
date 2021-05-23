using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_POSFE.Models;

namespace Web_POSFE.ViewModels
{
    public class IndexViewModel : BaseModelo //baseModelo creada para paginar
    {
        //Crear una propiedad para paginar los registros del procedimiento almacenado       
        public List<Producto> Productos { get; set; }

    }
}
