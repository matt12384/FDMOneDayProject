using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    interface IUserRepository
    {
        User GetUserByEmailAddress(string emailAddress);
        
        void AddUser(User user);
    }
}
