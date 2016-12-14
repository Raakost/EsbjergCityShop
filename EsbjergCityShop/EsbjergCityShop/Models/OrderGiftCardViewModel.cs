using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gateway.Models;

namespace EsbjergCityShop.Models
{
    public class OrderGiftCardViewModel
    {
        public Order Order { get; set; }
        public List<GiftCard> GiftCards { get; set; }
    }
}