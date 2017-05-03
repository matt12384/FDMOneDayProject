using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using ModelPoco;
using OneDayProjectMvc.BasketServiceReference;
using OneDayProjectMvc.UserServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace OneDayProjectMvc.Controllers
{
    public class UserController : Controller
    {
        UserServiceClient userServiceClient = new UserServiceClient();
        BasketServiceClient basketServiceClient = new BasketServiceClient();

        public ActionResult Create()
        {
            return View();
        }


        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            userServiceClient.AddUser(user);

            string firstName = Request.Form["FirstName"];

            var ident = new ClaimsIdentity(
              new[] { 
                  new Claim(ClaimTypes.NameIdentifier, firstName),
                  new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"),

                  new Claim(ClaimTypes.Name, firstName),
                },
              DefaultAuthenticationTypes.ApplicationCookie);

            HttpContext.GetOwinContext().Authentication.SignIn(
               new AuthenticationProperties { IsPersistent = false }, ident);

            return RedirectToAction("Index", "Home");
        }
    }
}
