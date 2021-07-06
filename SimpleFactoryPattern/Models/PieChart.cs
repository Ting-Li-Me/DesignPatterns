using System;

namespace SimpleFactoryPattern.Models
{
    using Interfaces;
    public class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("Creating PieChart");
        }

        public void Display()
        {
            Console.WriteLine("Displaying PieChart");
        }

    }
}
