using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceBlazor.Models.Response;
using WebServiceBlazor.Models;
using WebServiceBlazor.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace WebServiceBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Producto>> _respuesta = new Respuesta<List<Producto>>();
            try
            {
                using (ZEUS_POS_FEContext db = new ZEUS_POS_FEContext()) //using: se usa para abrir y cerrar la cn a la BDs
                {
                    var lst = db.Productos.ToList();//variable que contiene un select de la tabla producto
                    _respuesta.exito = 1;
                    _respuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);//Ok: metodo nativo de MVC API para regresar el objeto
        }
        [HttpGet("{Id}")]
        public IActionResult Get(string Id)
        {
            Respuesta<Producto> _respuesta = new Respuesta<Producto>();
            try
            {
                using (ZEUS_POS_FEContext db = new ZEUS_POS_FEContext()) //using: se usa para abrir y cerrar la cn a la BDs
                {
                    var lst = db.Productos.Find(Id);//variable que contiene un select de la tabla producto
                    _respuesta.exito = 1;
                    _respuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);//Ok: metodo nativo de MVC API para regresar el objeto
        }
        [HttpPost]
        public IActionResult Add(ProductoRequest model)
        {
            Respuesta<object> _respuesta = new Respuesta<object>();
            try
            {
                using (ZEUS_POS_FEContext db = new ZEUS_POS_FEContext()) //using: se usa para abrir y cerrar la cn a la BDs
                {
                    Producto _prod = new Producto();

                    _prod.IdPro = model.IdPro;//_prod: entidad que contiene las columnas de la tabla obtenida 
                    _prod.Idprovee = model.Idprovee;//model: es el dato que contiene despues de pedirlo
                    _prod.DescripcionLarga = model.DescripcionLarga;
                    _prod.Frank = model.Frank;
                    _prod.PreCompraS = model.PreCompraS;
                    _prod.PreCompra = 0;//model.PreCompra
                    _prod.StockActual =0;// model.StockActual
                    _prod.IdCat = model.IdCat;
                    _prod.IdMarca = model.IdMarca;
                    _prod.Foto = "-"; //envia una url de la foto . model.Foto
                    _prod.PreVntaxMenor = model.PreVntaxMenor;
                    _prod.PreVntaxMayor = 0;//model.PreVntaxMayor
                    _prod.PreVntadolar = 0; //model.PreVntadolar
                    _prod.UndMedida = model.UndMedida;
                    _prod.PesoUnit = 0;//model.PesoUnit
                    _prod.UtilidadUnit = model.PreVntaxMenor-model.PreCompraS;
                    _prod.TipoProdcto = model.TipoProdcto;
                    _prod.ValorPorCant = 0;//model.ValorPorCant
                    _prod.EstadoPro = "Activo";//model.EstadoPro
                    _prod.FechaCreaProServ = DateTime.Now;

                    db.Productos.Add(_prod);//Add: Metodo que agrega
                    db.SaveChanges();//SaveChanges: Guarda la trx realizada

                    _respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);//Ok: metodo nativo de MVC API para regresar el objeto
        }
        [HttpPut]
        public IActionResult Edit(ProductoRequest model)
        {
            Respuesta<object> _respuesta = new Respuesta<object>();
            try
            {
                using (ZEUS_POS_FEContext db = new ZEUS_POS_FEContext()) //using: se usa para abrir y cerrar la cn a la BDs
                {
                    Producto _prod = db.Productos.Find(model.IdPro);//busca el registro que se va actualizar

                    _prod.IdPro = model.IdPro;//_prod: entidad que contiene las columnas de la tabla obtenida 
                    _prod.Idprovee = model.Idprovee;//model: es el dato que contiene despues de pedirlo
                    _prod.DescripcionLarga = model.DescripcionLarga;
                    _prod.Frank = model.Frank;
                    _prod.PreCompraS = model.PreCompraS;
                    _prod.PreCompra = model.PreCompra;
                    _prod.StockActual = model.StockActual;
                    _prod.IdCat = model.IdCat;
                    _prod.IdMarca = model.IdMarca;
                    _prod.Foto = model.Foto; //envia una url de la foto
                    _prod.PreVntaxMenor = model.PreVntaxMenor;
                    _prod.PreVntaxMayor = model.PreVntaxMayor;
                    _prod.PreVntadolar = model.PreVntadolar;
                    _prod.UndMedida = model.UndMedida;
                    _prod.PesoUnit = model.PesoUnit;
                    _prod.UtilidadUnit = model.UtilidadUnit;
                    _prod.TipoProdcto = model.TipoProdcto;
                    _prod.ValorPorCant = model.ValorPorCant;
                    _prod.EstadoPro = model.EstadoPro;
                    _prod.FechaCreaProServ = model.FechaCreaProServ;

                    db.Entry(_prod).State = EntityState.Modified;//linea de codigo para modificar
                    db.SaveChanges();//SaveChanges: Guarda la trx realizada

                    _respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);//Ok: metodo nativo de MVC API para regresar el objeto
        }
        [HttpDelete("{Id}")]
        public IActionResult delete(string Id)
        {
            Respuesta<object> _respuesta = new Respuesta<object>();
            try
            {
                using (ZEUS_POS_FEContext db = new ZEUS_POS_FEContext()) //using: se usa para abrir y cerrar la cn a la BDs
                {
                    Producto _prod = db.Productos.Find(Id);//busca el registro que se va actualizar

                    db.Remove(_prod);//linea de codigo para eliminar
                    db.SaveChanges();//SaveChanges: Guarda la trx realizada

                    _respuesta.exito = 1;
                }
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);//Ok: metodo nativo de MVC API para regresar el objeto
        }
    }
}
