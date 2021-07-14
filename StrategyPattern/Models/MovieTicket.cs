namespace StrategyPattern.Models
{
    using Interfaces;
    class MovieTicket
    {
        private Discount discount;
        private double price;

        public double Price { get { return discount.Calculate(price); } set { price = value; } }

        public void SetDiscount(Discount discount)
        {
            this.discount = discount;
        }

    }
}
