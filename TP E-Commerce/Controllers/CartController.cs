using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_E_Commerce.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            BE.Cart carrito = Session["Carrito"] as BE.Cart;
            return View(carrito);
        }

        // GET: Cart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult ActualizarPrecio()
        {
            BE.Cart carrito = Session["Carrito"] as BE.Cart;
            return View(carrito);
        }

        public ActionResult EliminarDelCarrito(int id)
        {
            try
            {
                BL.ProductBL business = new BL.ProductBL();
                var producto = business.GetProducts().Where(x => x.Id == id).FirstOrDefault();
                BE.Cart carritoActual = Session["Carrito"] as BE.Cart;
                var lista = carritoActual.ProductList;
                int indice = lista.FindIndex(prod => prod.Product.Id == id);
                lista.RemoveAt(indice);
                return View("Index", carritoActual);
            }
            catch
            {
                return View("Index", Session["Carrito"] as BE.Cart);
            }
        }

        // POST: Cart/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Comprar(BE.Cart carrito)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
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

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
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
