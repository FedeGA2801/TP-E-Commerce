using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_E_Commerce.Controllers
{
    public class UsuarioController : Controller
    {
        BL.UsuarioBL gestor = new BL.UsuarioBL();
        // GET: Usuario
        public ActionResult ListUsuarios()
        {
            var usuaios = gestor.ListarUsuarios();
            return View(usuaios);
        }

    }
}
