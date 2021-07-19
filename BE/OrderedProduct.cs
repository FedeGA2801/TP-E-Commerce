using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrderedProduct : IdentityBase
    {
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }

        public int CartID { get; set; }

        public OrderedProduct(BE.Product producto)
        {
            Quantity = 1;
            Product = producto;
        }

        public OrderedProduct()
        {
        }

    }
}
