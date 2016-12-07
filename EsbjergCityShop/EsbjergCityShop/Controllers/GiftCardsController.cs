using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;
using Gateway.Models;

namespace EsbjergCityShop.Controllers
{
    public class GiftCardsController : Controller
    {
        // GET: GiftCards
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateGiftCard(double amount)
        {
            var newCard = new GiftCard();
            newCard.Amount = amount;
            newCard.CardNumber = Guid.NewGuid().ToString();
            var cart = ShoppingCart.GetCart();
            cart.AddItemToCart(newCard);
            return RedirectToAction("Index");
        }

        public ActionResult GiftCardBalance()
        {
            return View();
        }
    }
}