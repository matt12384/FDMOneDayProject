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
    class ProductRepositoryTests
    {
        [Test]
        public void GetAllProducts_ReturnsAnEmptyList_WhenDatabaseIsEmpty()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 0;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllProducts_ReturnsAListOfOne_WhenCalledWithOneProductInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            Mock<Product> mockUser = new Mock<Product>();
            productsInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 1;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllProducts_ReturnsAListOfTwo_WhenCalledWithTwoProductsInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            Mock<Product> mockProduct = new Mock<Product>();
            productsInDatabase.Add(mockProduct.Object);
            Mock<Product> mockProduct2 = new Mock<Product>();
            productsInDatabase.Add(mockProduct2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 2;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllProducts_ReturnsAListofProductsEqualToThoseInDatabase_WhenCalled()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            Mock<Product> mockProduct = new Mock<Product>();
            productsInDatabase.Add(mockProduct.Object);
            Mock<Product> mockProduct2 = new Mock<Product>();
            productsInDatabase.Add(mockProduct2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            List<Product> expectedList = new List<Product>();
            expectedList.Add(mockProduct.Object);
            expectedList.Add(mockProduct2.Object);

            //Act
            List<Product> actualList = productRepository.GetAllProducts();

            //Assert
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void GetProductById_ReturnsNull_WhenPassedProductIdThatDoesNotExistInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int userId = 6;
            Mock<Product> mockProduct = new Mock<Product>();
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);

            //Act
            Product actualResult = productRepository.GetProductById(userId);

            //Assert
            Assert.IsNull(actualResult);
        }

        [Test]
        public void GetProductById_ReturnsProductFromDatabaseWithProductIdMatchingIntPassedIntoTheMethod_WhenPassedAnInt()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int productId = 1;
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.ProductId = productId;
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase)
                .WithFind(productsInDatabase, "ProductId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<OneDayProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);

            //Act
            Product actualResult = productRepository.GetProductById(productId);

            //Assert
            Assert.AreSame(mockProduct.Object, actualResult);
        }
    }
}
