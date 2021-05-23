using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_POSFE.Models;

namespace Web_POSFE.Servicios
{
    public class CatalogoDAO : IDisposable
    {
        ZEUS_POS_FEContext db = new ZEUS_POS_FEContext();
        private bool disposedValue;

        public IEnumerable<Proveedor> ListarProveedores()
        {
            return db.Proveedors.ToList();
        }
        public IEnumerable<Categoria> ListarCategorias()
        {
            return db.Categorias.ToList();
        }
        public IEnumerable<Marca> ListarMarcas()
        {
            return db.Marcas.ToList();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~CatalogoDAO()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
