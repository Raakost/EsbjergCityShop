namespace Gateway.Models
{
    public class GiftCard : AbstractId
    {
        public string CardNumber { get; set; }
        public double Amount { get; set; }
    }
}