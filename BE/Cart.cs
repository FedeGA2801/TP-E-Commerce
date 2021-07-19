using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cart : IdentityBase
    {
        public string CartId { get; set; }
        public DateTime DateCreated { get; set; }
        public double TotalPrice { get; set; }
        public List<OrderedProduct> ProductList { get; set; }
        public virtual CustomerOrder CustomerData { get; set; }


        public Cart()
        {
            ProductList = new List<OrderedProduct>();
            CustomerData = new CustomerOrder();
        }
    }
}
