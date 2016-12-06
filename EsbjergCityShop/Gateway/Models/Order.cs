using System;
using System.Collections.Generic;

namespace Gateway.Models
{
    public class Order : AbstractId
    {
        public DateTime DateOfPurchase { get; set; }
        public List<GiftCard> GiftCards { get; set; }
        public bool IsCompleted { get; set; }
    }
}