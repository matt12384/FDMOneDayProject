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
    interface IUserService
    {
        [OperationContract]
        User GetUserByEmailAddress(string username);

        [OperationContract]
        void AddUser(User user);
    }
}
