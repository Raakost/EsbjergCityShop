using System.ComponentModel.DataAnnotations;

namespace Gateway.Models
{
    public class GiftCard : AbstractId
    {
        [Required(ErrorMessage = "Indtast kortnummer")]
        [Display(Name = "Kort nummer")]
        public string CardNumber { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Indtast et gyldigt beløb")]
        [Required(ErrorMessage = "Indtast et beløb")]
        [Display(Name = "Saldo")]
        public double Amount { get; set; }
    }
}