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
        private IServiceGateway<Order> _og = new Facade().GetOrderGateway();

        [HttpGet]
        public ActionResult Index()
        {
            var cart = System.Web.HttpContext.Current.Session["ShoppingCart"] as ShoppingCart;
            return View(cart.GiftCards);
        }


        [HttpPost]
        public ActionResult CreateOrder()
        {
            var cart = System.Web.HttpContext.Current.Session["ShoppingCart"] as ShoppingCart;
            var order = new Order()
            {
                Customer = Session["customer"] as Customer,
                GiftCards = cart.GiftCards,
                DateOfPurchase = DateTime.Now,
            };
            _og.Create(order);
            Session["ShoppingCart"] = null;
            return View(order);
        }
    }
}
