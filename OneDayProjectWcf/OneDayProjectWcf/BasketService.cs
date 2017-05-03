using ModelPoco;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    public class BasketService : IBasketService
    {
        #region Constructor
        BasketRepository repository;

        public BasketService()
        {
            repository = new BasketRepository();
        }
        #endregion

        public void CreateBasket(int userId, Basket basket)
        {
            repository.CreateBasket(userId, basket);
        }

        public int GetCurrentBasketIdFromUsername(string username)
        {
            return repository.GetCurrentBasketIdFromUsername(username);
        }

        public List<Product> GetProductsInCurrentBasket(string username)
        {
            return repository.GetProductsInCurrentBasket(username);
        }
    }
}
