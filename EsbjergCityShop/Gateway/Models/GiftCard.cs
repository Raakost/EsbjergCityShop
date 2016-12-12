using System.ComponentModel.DataAnnotations;

namespace Gateway.Models
{
    public class GiftCard : AbstractId
    {
        [Display(Name = "Kort nummer")]
        public string CardNumber { get; set; }

        [Display(Name = "Saldo")]
        public double Amount { get; set; }
    }
}