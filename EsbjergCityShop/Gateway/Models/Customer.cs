using System.Collections.Generic;

namespace Gateway.Models
{
   public class Customer : AbstractId
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }    //not sure how to...
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }
    }
}
