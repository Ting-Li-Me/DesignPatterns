namespace StrategyPattern.Models
{
    using Interfaces;
    using System;
    class StudentDiscount : Discount
    {
        private const double DISCOUNT = 0.8;

        public double Calculate(double price)
        {
            Console.WriteLine("Student Ticket:");
            return price * DISCOUNT;
        }
    }
}
