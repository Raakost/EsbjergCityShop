using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;
using Gateway;
using Gateway.Models;
using Gateway.ServiceGateways;

namespace EsbjergCityShop.Controllers
{
    public class GiftCardsController : Controller
    {
        private readonly GiftCardServiceGateway _gg = new Facade().GetGiftCardGateway();

        [HttpGet]
        public ActionResult CreateGiftCard()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateGiftCard(double? amount)
        {
            if (amount.HasValue && amount != 0.0)
            {
                var newCard = new GiftCard();
                newCard.Amount = amount.Value;
                newCard.CardNumber = Guid.NewGuid().ToString();
                var cart = ShoppingCart.GetCart();
                cart.AddItemToCart(newCard);
            }
            return RedirectToAction("CreateGiftCard");

        }

        [HttpGet]
        public ActionResult GiftCardBalance()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GiftCardBalance(string cardNumber)
        {
            var giftCard = _gg.GetByCardNumber(cardNumber);
            return View(giftCard);
        }
    }
}