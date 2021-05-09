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
        public int ProductId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Product Product { get; set; }
    }
}
