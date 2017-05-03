using ModelPoco;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProjectWcf
{
    class UserService : IUserService
    {
        UserRepository repository;

        public UserService()
        {
            repository = new UserRepository();
        }

        public User GetUserByEmailAddress(string emailAddress)
        {
            return repository.GetUserByEmailAddress(emailAddress);
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }
    }
}
