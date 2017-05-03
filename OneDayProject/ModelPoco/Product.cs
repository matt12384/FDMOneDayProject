using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelPoco
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Range(0, 100, ErrorMessage = "Negative values not allowed.")]
        [Required(ErrorMessage = "Number in stock is required.")]
        public int NumberInStock { get; set; }

        [Required(ErrorMessage = "Image link is required.")]
        public string ImageLink { get; set; }

        [Required(ErrorMessage = "Search terms are required.")]
        public string SearchTerms { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
