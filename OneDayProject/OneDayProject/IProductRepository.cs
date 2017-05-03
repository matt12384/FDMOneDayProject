using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    interface IProductRepository
    {
        List<Product> GetAllProducts();

        Product GetProductById(int productId);
    }
}
