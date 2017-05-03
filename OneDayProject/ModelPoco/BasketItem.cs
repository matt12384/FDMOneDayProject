using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class BasketItem
    {
        [Key]
        [Column(Order = 1)]
        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Please enter a value greater than 0.")]
        public int Quantity { get; set; }
    }
}
