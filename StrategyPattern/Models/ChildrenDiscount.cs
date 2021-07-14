namespace StrategyPattern.Models
{
    using Interfaces;
    using System;
    class ChildrenDiscount : Discount
    {
        private const double DISCOUNT = 10;

        public double Calculate(double price)
        {
            Console.WriteLine("Children Ticket:");
            return price - DISCOUNT;
        }
    }
}
