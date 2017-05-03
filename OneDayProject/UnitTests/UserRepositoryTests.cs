using EntityFramework.MoqHelper;
using ModelPoco;
using Moq;
using NUnit.Framework;
using OneDayProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void GetUserByEmailAddress_UserFoundByMethodIsTheSameAsUserInDatabase_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, User>(mockDbSet);
            UserRepository userRepository = new UserRepository(mockDatabasePlatform.Object);
            User expectedUser = usersInDatabase[0];

            //Act
            User actualResult = userRepository.GetUserByEmailAddress(emailAddress);

            //Assert
            Assert.AreEqual(expectedUser, actualResult);
        }

        [Test]
        public void AddUser_AddsUserToDatabase_WhenPassedAUserObject()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithAdd(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, User>(mockDbSet);
            UserRepository usersRepository = new UserRepository(mockDatabasePlatform.Object);
            Mock<User> expectedUser = new Mock<User>();
            //Act
            usersRepository.AddUser(expectedUser.Object);

            //Assert
            Assert.IsTrue(mockDbSet.Object.Contains(expectedUser.Object));
        }
    }
}
