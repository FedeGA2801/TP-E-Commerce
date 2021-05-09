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
        public virtual CustomerOrder CustomerOrder { get; set; }
    }
}
