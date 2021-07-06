using System;

namespace SimpleFactoryPattern.Models
{
    using Interfaces;
    public class LineChart : IChart
    {
        public LineChart()
        {
            Console.WriteLine("Creating LineChart");
        }

        public void Display()
        {
            Console.WriteLine("Displaying LineChart");
        }

    }
}
