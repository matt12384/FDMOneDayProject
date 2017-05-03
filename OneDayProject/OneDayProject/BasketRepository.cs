using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    public class BasketRepository : IBasketRepository
    {
        OneDayProjectEntities context;

        #region Constructors
        public BasketRepository()
        {
            context = new OneDayProjectEntities();
        }

        public BasketRepository(OneDayProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }
        #endregion

        #region Methods

        public void CreateBasket(int userId, Basket basket)
        {
            User user = context.Users.Find(userId);

            if (user.Baskets == null)
            {
                user.Baskets = new List<Basket>();
            }

            user.Baskets.Add(basket);

            context.SaveChanges();
        }

        public int GetCurrentBasketIdFromUsername(string username)
        {
            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetUserByEmailAddress(username);
            int userId = user.UserId;
            IQueryable<Basket> basket = (context.Baskets.Where(s => s.UserId.Equals(userId)));
            List<Basket> basketList = basket.ToList();
            Basket basketObject = basketList.Last();
            int basketId = basketObject.BasketId;

            return basketId;
        }

        public List<Product> GetProductsInCurrentBasket(string username)
        {
            ProductRepository productRepository = new ProductRepository();

            int basketId = GetCurrentBasketIdFromUsername(username);

            IQueryable<BasketItem> basketQueryable = null;

            basketQueryable = (context.BasketItems.Where(s => s.BasketId.Equals(basketId)));

            List<Product> productList = new List<Product>();

            foreach (BasketItem item in basketQueryable)
            {
                productList.Add(productRepository.GetProductById(item.ProductId));
            }
            return productList;
        }
        
        #endregion
    }
}
