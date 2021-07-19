using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;
using BL;
using System.Security.Claims;
using TP_E_Commerce.Models;
using System.Web.Mvc;

namespace TP_E_Commerce.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        UsuarioBL gestor = new UsuarioBL();
        public ActionResult Index()
        {
            if (Session["UserSession"] == null)
                return View("Login");
            else
                return RedirectToAction("Home", "Index");
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public JsonResult Login(Usuario u)
        {
            try
            {
                // TODO: Add insert logic here
                var usuario = gestor.ListarUsuarios().Where(user => user.Username == u.Username && user.Password == u.Password).FirstOrDefault();
                if (usuario != null)
                {
                    Session["UserSession"] = usuario;
                    Session["Carrito"] = new BE.Cart();
                    return Json(new { Ok = true, redirectURL = Url.Action("Index", "Home") });
                }

                else
                return Json(new { Ok = false, message= "Usuario o contraseña invalido" });
            }
            catch (Exception e)
            {
                return Json(new { Ok = false, message = "ERROR INESPERADO" });
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
