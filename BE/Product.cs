using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Product : IdentityBase
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public DateTime LastUpdated { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderedProduct> OrderedProducts { get; set; }
    }
}
