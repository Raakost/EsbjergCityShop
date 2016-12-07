using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gateway.Models;

namespace EsbjergCityShop.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            GiftCards = new List<GiftCard>();
        }

        public List<GiftCard> GiftCards { get; set; }

        public static ShoppingCart GetCart()
        {
            var cart = HttpContext.Current.Session["ShoppingCart"] as ShoppingCart;
            if (cart == null)
            {
                cart = new ShoppingCart();
                HttpContext.Current.Session["ShoppingCart"] = cart;
            }
            return cart;
        }

        public void AddItemToCart(GiftCard giftCard)
        {
            GiftCards.Add(giftCard);
        }

        public void RemoveItemFromCart(string cardNumber)
        {
            GiftCards.RemoveAll(x => x.CardNumber == cardNumber);
        }

        public void EmptyCart()
        {
            GiftCards.Clear();
        }
    }
}