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
    }
}
