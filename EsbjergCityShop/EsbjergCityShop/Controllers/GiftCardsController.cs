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
    [Authorize]
    public class GiftCardsController : Controller
    {
        private readonly GiftCardServiceGateway _gg = new Facade().GetGiftCardGateway();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult CreateGiftCard()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
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

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GiftCardBalance()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult GiftCardBalance(string cardNumber)
        {
            var giftCard = _gg.GetByCardNumber(cardNumber);
            return View(giftCard);
        }

        //[HttpDelete]
        //public ActionResult DeleteGiftCard(GiftCard giftCard)
        //{
        //    _gg.Delete(giftCard);
        //    return RedirectToAction("Create", "Orders");
        //}
    }
}