using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class ProductBL
    {
        public List<Product> GetProducts()
        {
            var db = new DAL.BaseDataService<Product>();
            List < Product > lista = db.Get();
            db.CerrarDB();
            return lista;
        }

        public BE.Product getProductInfo(int idProd)
        {
            var db = new DAL.BaseDataService<Product>();
            Product prod = db.GetById(idProd);
            db.CerrarDB();
            return prod;
        }
    }
}
