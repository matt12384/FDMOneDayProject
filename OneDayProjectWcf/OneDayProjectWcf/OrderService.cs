using ModelPoco;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    class OrderService : IOrderService
    {
        #region Constructor
        OrderRepository repository;

        public OrderService()
        {
            repository = new OrderRepository();
        }
        #endregion

        public void AddOrder(int basketId, Order order)
        {
            repository.AddOrder(basketId, order);
        }
    }
}
