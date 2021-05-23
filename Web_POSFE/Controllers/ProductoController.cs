using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_POSFE.Models;
using Web_POSFE.Servicios;
using Web_POSFE.ViewModels;

namespace Web_POSFE.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ZEUS_POS_FEContext db = new ZEUS_POS_FEContext();
        #region Lista de Items Paginados
        [HttpGet]
        public async Task<IActionResult> Index(
           string sortOrder,
           string currentFilter,
           string searchString,
           int? pageNumber)
        {
            //Para Ordenar
            ViewData["CurrentSort"] = sortOrder;  //Para conservar la ordenacion en la paginacion
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CodSortParm"] = string.IsNullOrEmpty(sortOrder) ? "codcom_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "date" ? "date_desc" : "Date";
            //Para Paginacion
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            //Para buscar
            ViewData["CurrenFilter"] = searchString;
            //Cargar de registros de productos
            var productos = from s in db.Productos select s;
            //Filtrar los registros
            if (!String.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.DescripcionLarga.Contains(searchString) || s.IdPro.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    productos = (productos.OrderByDescending(s => s.DescripcionLarga)).Take(50);
                    break;
                case "codcom_desc":
                    productos = productos.OrderByDescending(s => s.IdPro);
                    break;
                //case "date":
                //    productos = productos.OrderByDescending(s => s.Detalle);
                //    break;
                //case "date_desc":
                //    productos = productos.OrderByDescending(s => s.Detalle);
                //    break;
                default:
                    productos = productos.OrderBy(s => s.DescripcionLarga);
                    break;
            }
            //Retornar los registros paginados de 5 en 5 por pagina
            int pageSize = 5;
            return View(await PaginatedList<Producto>.CreateAsync(productos.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        #endregion

        [HttpGet]
        public IActionResult Agregar()
        {
            try
            {
                ListarCatalogo();
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Agregar(Producto producto)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                if (ModelState.IsValid) //Si se ingresos datos correctos  a la vista
                {
                    db.Agregar(producto);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult Editar(string id)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                var producto = db.Buscar(id);
                if (producto != null)
                {
                    ListarCatalogo();
                    return View(producto);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Producto producto)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                if (ModelState.IsValid)
                {
                    db.Editar(producto);
                    return RedirectToAction("Index");
                }
                ListarCatalogo();
                return View();
            }
        }
        [HttpGet]
        public IActionResult Eliminar(string id)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                var producto = db.Buscar(id);
                if (producto != null)
                {
                    ListarCatalogo();
                    return View(producto);
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Eliminar(string id, bool flag = false)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                db.Eliminar(id);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Detalle(string id)
        {
            ListarCatalogo();
            using (ProductoDAO db = new ProductoDAO())
            {
                var prod = db.Buscar(id);
                return View(prod);
            }
        }
        void ListarCatalogo()
        {
            using (CatalogoDAO db = new CatalogoDAO())
            {
                ViewBag.Idprovee = db.ListarProveedores();
                ViewBag.IdCat = db.ListarCategorias();
                ViewBag.IdMarca = db.ListarMarcas();
            }
        }

        [HttpGet]
        public IActionResult ListarCatalogo(string nombre)
        {
            using (ProductoDAO db = new ProductoDAO())
            {
                var lista = db.ListarCatalogo(nombre).ToList(); //Obtiene los productos filtrados por nombre                
                return PartialView("PV_Catalogo", lista); //Cargar los resultados de la consulta en el partialview
            }
        }
        [HttpGet]
        public IActionResult ListarCatalogo2(string nombre)
        {
            var lista = (from N in db.Productos
                         where N.DescripcionLarga.Contains(nombre.ToUpper())
                         select N).Take(10);

            return PartialView("PV_Catalogo2", lista);
        }

    }
}
