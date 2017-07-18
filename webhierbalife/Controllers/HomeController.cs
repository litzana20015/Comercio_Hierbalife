using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webhierbalife.Controllers
{
    
    public class HomeController : Controller
    {
        private Models.TiendaHerbalifeEntities bd = new Models.TiendaHerbalifeEntities();
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Buscar(string id="" )
        {
            var productos = bd.Producto.Where(x => x.Descripcion.Contains(id)).ToList();
            return View(productos);
        }
    }
}