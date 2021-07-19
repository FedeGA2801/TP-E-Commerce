using BL;
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
        public ActionResult Index(int idCart)
        {
            CarritoBL carritobs = new CarritoBL();
            ProductBL prodbs = new ProductBL();
            BE.Cart carrito = carritobs.obtenerCarrito(idCart);
            carrito.ProductList = new List<BE.OrderedProduct>();
            carrito.ProductList = carritobs.obtenerProdsCarrito(idCart);
            foreach (var item in carrito.ProductList)
            {
                item.Product = new BE.Product();
            }
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

        public ActionResult EliminarDelCarrito(int idCart, int idProd)
        {
            try
            {
                BL.ProductBL business = new BL.ProductBL();
                var producto = business.GetProducts().Where(x => x.Id == idProd).FirstOrDefault();
                BL.CarritoBL carritobs = new CarritoBL();
                BE.Cart carritoActual = carritobs.obtenerCarrito(idCart);
                var lista = carritoActual.ProductList;
                int indice = lista.FindIndex(prod => prod.Product.Id == idProd);
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

        public ActionResult AgregarAlCarrito(int idCart, int idProd)
        {
            try
            {
                ProductBL business = new ProductBL();
                var producto = business.GetProducts().Where(x => x.Id == idProd).FirstOrDefault();

                CarritoBL carritobs = new CarritoBL();
                BE.Cart cart = carritobs.obtenerCarrito(idCart);

                if(cart.ProductList is null)
                {
                    cart.ProductList = new List<BE.OrderedProduct>();
                }
                
                if (cart.ProductList.Any(prod => prod.Product.Id == idProd))
                {
                    ViewBag.ErrorCarrito = "El producto ya se encuentra en el carrito";
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    BE.OrderedProduct prod = new BE.OrderedProduct(producto);
                    prod.CartID = idCart;
                    cart.ProductList.Add(carritobs.agregarItemCarrito(prod));
                    Session["Carrito"] = cart;
                    ViewBag.ErrorCarrito = null;
                    return RedirectToAction("Index", "Product");
                }

            }
            catch (Exception e)
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
