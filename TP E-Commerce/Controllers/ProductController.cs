using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace TP_E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            if (Session["UserSession"] == null)
                return RedirectToAction("Index", "Login");
            else
            {
                ProductBL business = new ProductBL();
                var products = business.GetProducts();
                return View(products);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult AgregarAlCarrito(int id)
        {
            try
            {
                ProductBL business = new ProductBL();
                var producto = business.GetProducts().Where(x => x.Id == id).FirstOrDefault();
                BE.Cart carritoActual = Session["Carrito"] as BE.Cart;
                var lista = carritoActual.ProductList;
                if(lista.Any(prod => prod.Product.Id == id))
                {
                    ViewBag.ErrorCarrito = "El producto ya se encuentra en el carrito";
                    return RedirectToAction("Index");
                }
                else
                {
                    lista.Add(new BE.OrderedProduct(producto));
                    ViewBag.ErrorCarrito = null;
                    return RedirectToAction("Index");
                }
                
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
