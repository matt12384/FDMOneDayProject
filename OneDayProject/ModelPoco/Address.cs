using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required]
        public string City { get; set; }
        public string County { get; set; }
        [Required]
        public string Postcode { get; set; }
        public string Country { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
