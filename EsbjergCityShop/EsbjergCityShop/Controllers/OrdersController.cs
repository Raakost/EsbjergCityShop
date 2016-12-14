using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;
using Gateway;
using Gateway.Models;
using Microsoft.Ajax.Utilities;

namespace EsbjergCityShop.Controllers
{
    public class OrdersController : Controller
    {
        private IServiceGateway<GiftCard> _gg = new Facade().GetGiftCardGateway();
        private IServiceGateway<Order> _og = new Facade().GetOrderGateway();
        private IServiceGateway<Customer> _cg = new Facade().GetCustomerGateway();


        // GET: giftcards
        public ActionResult Index()
        {
            var cart = System.Web.HttpContext.Current.Session["ShoppingCart"] as ShoppingCart;
            return View(cart.GiftCards);

        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult CreateOrder()
        {
            var cart = System.Web.HttpContext.Current.Session["ShoppingCart"] as ShoppingCart;
            var order = new Order()
            {
                GiftCards = cart.GiftCards,
                DateOfPurchase = DateTime.Now
            };
            return View(order);
        }
    }
}
