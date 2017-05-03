using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    public class BasketItemRepository : IBasketItemRepository
    {
        OneDayProjectEntities context;

        public BasketItemRepository()
        {
            context = new OneDayProjectEntities();
        }

        public BasketItemRepository(OneDayProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }

        public void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem)
        {
            Basket basket = context.Baskets.Find(basketId);
            Product product = context.Products.Find(productId);

            if (product.BasketItems == null && basket.BasketItems == null)
            {
                basket.BasketItems = new List<BasketItem>();
                product.BasketItems = new List<BasketItem>();  
            }

            basket.BasketItems.Add(basketItem);
            product.BasketItems.Add(basketItem);

            context.SaveChanges();
        }
        
        public void RemoveItemFromBasket(int basketId, int productId)
        {
            BasketItem basketItem = context.BasketItems.Find(basketId, productId);

            context.BasketItems.Remove(basketItem);

            context.SaveChanges();
        }
    }
}
