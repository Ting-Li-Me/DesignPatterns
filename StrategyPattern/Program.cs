namespace StrategyPattern
{
    using Interfaces;
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket movieTicket = new MovieTicket();
            double originalPrice = 60.0;
            double currentPrice;

            movieTicket.Price = originalPrice;
            Console.WriteLine($"Original Price is {originalPrice}");
            Console.WriteLine("---------------------------------");

            string input = string.Empty;
            string type = string.Empty;

            Discount discount;

            while ((input = Console.ReadLine()) != "0")
            {
                type = input;

                if (type == "1")
                {
                    discount = new ChildrenDiscount();
                }
                else if (type == "2")
                {
                    discount = new StudentDiscount();
                }
                else if (type == "3")
                {
                    discount = new VIPDiscount();
                }
                else
                {
                    continue;
                }

                movieTicket.SetDiscount(discount);

                currentPrice = movieTicket.Price;
                Console.WriteLine($"After discount price is: {currentPrice}");

            }




        }
    }
}
