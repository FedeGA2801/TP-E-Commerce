using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CarritoBL
    {
        public void confirmarCompra(BE.Cart cart)
        {
            var db = new DAL.BaseDataService<BE.Cart>();
            db.Create(cart);
        }

        public List<BE.OrderedProduct> obtenerProdsCarrito(int idCarrito)
        {
            var db = new DAL.BaseDataService<BE.OrderedProduct>();
            List<BE.OrderedProduct> prods = db.Get().Where(prod => prod.CartID == idCarrito).ToList();
            db.CerrarDB();
            return prods;
        }

        public BE.Cart crearCarrito(BE.Cart carrito)
        {
            var db = new DAL.BaseDataService<BE.Cart>();
            carrito.DateCreated = DateTime.Today;
            BE.Cart cart = db.Create(carrito);
            db.CerrarDB();
            return cart;
        }

        public BE.Cart obtenerCarrito(int id)
        {
            var db = new DAL.BaseDataService<BE.Cart>();
            BE.Cart cart = db.GetById(id);
            db.CerrarDB();
            return cart;
        }

        public BE.OrderedProduct agregarItemCarrito(BE.OrderedProduct prod)
        {
            var db = new DAL.BaseDataService<BE.OrderedProduct>();
            BE.OrderedProduct prodFin = db.Create(prod);
            db.CerrarDB();
            return prodFin;
        }
    }
}
