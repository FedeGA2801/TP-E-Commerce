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
            return db.Get();
        }
    }
}
