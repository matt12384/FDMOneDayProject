using Microsoft.AspNet.Identity;
using ModelPoco;
using OneDayProject;
using OneDayProjectMvc.BasketItemServiceReference;
using OneDayProjectMvc.BasketServiceReference;
using OneDayProjectMvc.OrderServiceReference;
using OneDayProjectMvc.ProductServiceReference;
using OneDayProjectMvc.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OneDayProjectMvc.Controllers
{
    public class ProductController : Controller
    {
        OneDayProjectEntities db = new OneDayProjectEntities();

        BasketServiceClient basketServiceClient = new BasketServiceClient();
        ProductServiceClient productServiceClient = new ProductServiceClient();
        UserServiceClient userServiceClient = new UserServiceClient();
        BasketItemServiceClient basketItemServiceClient = new BasketItemServiceClient();
        OrderServiceClient orderServiceClient = new OrderServiceClient();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            //TempData["productId"] = id;
            return View(productServiceClient.GetProductById(id));
        }

        public ActionResult AddToBasket(BasketItem basketItem, int productId)
        {
            string username = User.Identity.GetUserName();

            int basketId = basketServiceClient.GetCurrentBasketIdFromUsername(username);

            basketItem.Quantity = 1;

            basketItemServiceClient.PopulateBasketAndProductKeys(basketId, productId, basketItem);

            return RedirectToAction("Basket");
        }

        public ActionResult Basket()
        {
            string username = User.Identity.GetUserName();

            return View(basketServiceClient.GetProductsInCurrentBasket(username));
        }

        public ActionResult RemoveItemFromBasket(int id)
        {
            string username = User.Identity.GetUserName();

            int basketId = basketServiceClient.GetCurrentBasketIdFromUsername(username);

            basketItemServiceClient.RemoveItemFromBasket(basketId, id);

            return RedirectToAction("Basket");
        }

        public ActionResult PlaceOrder(Order order)
        {
            string username = User.Identity.GetUserName();
            int basketId = basketServiceClient.GetCurrentBasketIdFromUsername(username);

            orderServiceClient.AddOrder(basketId, order);

            Basket basket = new Basket();

            User user = userServiceClient.GetUserByEmailAddress(username);
            int userId = user.UserId;
            basketServiceClient.CreateBasket(userId, basket);

            return RedirectToAction("Basket");
        }
    }
}
