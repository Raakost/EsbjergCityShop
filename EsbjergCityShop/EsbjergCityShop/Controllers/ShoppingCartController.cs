using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;

namespace EsbjergCityShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult CartIndex()
        {
            ShoppingCart cart = (ShoppingCart)Session["shoppingCart"];
            if (cart == null)
            {
                cart = new ShoppingCart();
                Session["shoppingCart"] = cart;
            }
            return PartialView();
        }
    }
}