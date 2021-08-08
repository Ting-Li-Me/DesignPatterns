namespace StrategyPattern.Models
{
    using Interfaces;
    class MovieTicket
    {
        private IDiscount discount;
        private double price;

        public double Price { get { return discount.Calculate(price); } set { price = value; } }

        public void SetDiscount(IDiscount discount)
        {
            this.discount = discount;
        }

    }
}
