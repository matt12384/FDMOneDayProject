﻿using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    [ServiceContract]
    interface IOrderService
    {
        [OperationContract]
        void AddOrder(int basketId, Order order);
    }
}
