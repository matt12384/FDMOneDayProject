using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class Order
    {
        public int OrderId { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
