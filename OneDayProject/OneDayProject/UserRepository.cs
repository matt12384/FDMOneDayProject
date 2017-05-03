using ModelPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayProject
{
    public class UserRepository : IUserRepository
    {
        OneDayProjectEntities context;

        #region Constructors
        public UserRepository()
        {
            context = new OneDayProjectEntities();
        }

        public UserRepository(OneDayProjectEntities projectEntities)
        {
            this.context = projectEntities;
        }
        #endregion

        #region Methods

        public User GetUserByEmailAddress(string emailAddress)
        {
            IQueryable<User> userIQueryable = null;

            userIQueryable = (context.Users.Where(s => s.EmailAddress.Contains(emailAddress)));
            List<User> list = userIQueryable.ToList();
            User user = list[0];

            return user;
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);

            context.SaveChanges();
        }

        #endregion
    }
}
