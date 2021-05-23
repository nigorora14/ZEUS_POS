using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_POSFE.Models;

namespace Web_POSFE.Servicios
{
    public class ProductoDAO : IDisposable
    {
        ZEUS_POS_FEContext db = new ZEUS_POS_FEContext();
        private bool disposedValue;

        public int Agregar(Producto producto)
        {
            try
            {
                db.Productos.Add(producto);
                return db.SaveChanges(); //confirma la grabacion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Editar(Producto producto)
        {
            try
            {
                db.Productos.Update(producto);
                return db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Eliminar(string id)
        {
            try
            {
                var producto = db.Productos.Where(p => p.IdPro == id).SingleOrDefault(); //Consulta que Devuelve una sola fila
                if (producto != null)
                {
                    db.Productos.Remove(producto); //Eliminar el producto
                    db.SaveChanges(); //Confirmar la eliminacion
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Producto Buscar(string id)
        {
            try
            {
                var producto = db.Productos.Where(p => p.IdPro == id).SingleOrDefault(); //Consulta que Devuelve una sola fila
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Producto> Listar()
        {
            try
            {
                var productos = db.Productos.ToList().Take(100); //Consulta que Devuelve 10  filas
                return productos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Producto> ListarCatalogo(string nombre)
        {
            var lista = (from N in db.Productos
                         where N.DescripcionLarga.Contains(nombre.ToUpper())
                         select N).Take(10).ToList();
            return lista;
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
        // ~ProductoDAO()
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
