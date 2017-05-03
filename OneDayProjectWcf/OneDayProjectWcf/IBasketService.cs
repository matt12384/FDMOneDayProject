using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    [ServiceContract]
    interface IBasketService
    {
        [OperationContract]
        void CreateBasket(int userId, Basket basket);

        [OperationContract]
        int GetCurrentBasketIdFromUsername(string username);

        [OperationContract]
        List<Product> GetProductsInCurrentBasket(string username);
    }
}
