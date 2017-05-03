using ModelPoco;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    class ProductService : IProductService
    {
        ProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return repository.GetProductById(productId);
        }
    }
}
