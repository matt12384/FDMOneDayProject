using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class Basket
    {
        public int BasketId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        
        public ICollection<BasketItem> BasketItems { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}
