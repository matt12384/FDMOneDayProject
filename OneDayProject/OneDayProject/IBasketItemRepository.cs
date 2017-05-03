using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    interface IBasketItemRepository
    {
        void PopulateBasketAndProductKeys(int basketId, int productId, BasketItem basketItem);
    }
}
