using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    public class ProductRepository : IProductRepository
    {
        OneDayProjectEntities context;

        public ProductRepository()
        {
            context = new OneDayProjectEntities();
        }

        public ProductRepository(OneDayProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> productsFromDatabase = new List<Product>();

            if (context.Products != null)
            {
                foreach (Product product in context.Products)
                {
                    productsFromDatabase.Add(product);
                }
            }
            return productsFromDatabase;
        }

        public Product GetProductById(int productId)
        {
            Product product = null;

            product = context.Products.Find(productId);

            return product;
        }
    }
}
