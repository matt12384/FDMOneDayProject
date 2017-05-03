using ModelPoco;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    class BasketItemService : IBasketItemService
    {
        BasketItemRepository repository;

        public BasketItemService()
        {
            repository = new BasketItemRepository();
        }

        public void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem)
        {
            repository.PopulateBasketAndProductKeys(basketId, productId, basketItem);
        }

        public void RemoveItemFromBasket(int basketId, int productId)
        {
            repository.RemoveItemFromBasket(basketId, productId);
        }
    }
}
