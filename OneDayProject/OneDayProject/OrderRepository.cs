using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    public class OrderRepository
    {
        OneDayProjectEntities context;

        #region Constructors
        public OrderRepository()
        {
            context = new OneDayProjectEntities();
        }

        public OrderRepository(OneDayProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }
        #endregion

        public void AddOrder(int basketId, Order order)
        {
            Basket basket = context.Baskets.Find(basketId);

            if (basket.Orders == null)
            {
                basket.Orders = new List<Order>();
            }
            basket.Orders.Add(order);

            context.SaveChanges();
        }
    }
}
