using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;
using Gateway.Models;

namespace EsbjergCityShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult CartIndex()
        {
            var cart = ShoppingCart.GetCart();
            return PartialView(cart);
        }

        public ActionResult RemoveItemFromCart(string cardNumber)
        {
            var cart = ShoppingCart.GetCart();
            cart.RemoveItemFromCart(cardNumber);
            return Redirect(Request.UrlReferrer.ToString());
        }

    }
}