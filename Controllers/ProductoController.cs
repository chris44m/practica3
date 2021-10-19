using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using practica3.Models;

namespace practica3.Controllers
{
    public class ProductoController : Controller
    {
        private readonly  ProductoContext _context;
        public ProductoController(ProductoContext context){
            _context=context;
        }

        public IActionResult Productos(){
            var productos=_context.Productos.Include(x =>x.Categoria).OrderBy(r=>r.nombre).ToList();
            return View(productos);
        }


        /************Nuevo Producto *******************/
        public IActionResult NuevoProducto(){
           ViewBag.Categorias= _context.Categorias.ToList().Select(r => new SelectListItem(r.nombre, r.id.ToString()));
            return View();

        }
        [HttpPost]
        public IActionResult NuevoProducto(Producto r){
            if(ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevoProductoConfirmacion(){
            return View();
        }

        /************ Borrar Productooo *********************/
        [HttpPost]
        public IActionResult BorrarProducto(int id){
            /*_context.Regiones.First(r =>r.Id==id);*/ /* primera forma de borrar*/
            var productos=_context.Productos.Find(id);// segunda forma 
            _context.Remove(productos);
            _context.SaveChanges();
            return RedirectToAction("Productos");
        }



        /**************************CATEGORIAAAAAA */
         public IActionResult NuevaCategoria(){
            return View();

        }
        [HttpPost]
        public IActionResult NuevaCategoria(Categoria r){
            if(ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaCategoriaConfirmacion");
            }
            return View(r);
        }
        public IActionResult NuevaCategoriaConfirmacion(){
            return View();
        }

    }
}