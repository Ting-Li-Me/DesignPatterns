namespace StrategyPattern.Models
{
    using Interfaces;
    using System;
    class VIPDiscount : IDiscount
    {
        private const double DISCOUNT = 0.5;

        public double Calculate(double price)
        {
            Console.WriteLine("VIP Ticket:");
            return price * DISCOUNT;
        }
    }
}
