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
    interface IBasketItemService
    {
        [OperationContract]
        void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem);

        [OperationContract]
        void RemoveItemFromBasket(int basketId, int productId);
    }
}
