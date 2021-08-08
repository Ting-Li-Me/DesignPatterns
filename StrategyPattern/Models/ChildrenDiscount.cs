namespace StrategyPattern.Models
{
    using Interfaces;
    using System;
    class ChildrenDiscount : IDiscount
    {
        private const double DISCOUNT = 10;

        public double Calculate(double price)
        {
            Console.WriteLine("Children Ticket:");
            return price - DISCOUNT;
        }
    }
}
