using System;

namespace SimpleFactoryPattern.Models
{
    using Interfaces;
    public class HistogramChart:IChart
    {
        public HistogramChart()
        {
            Console.WriteLine("Creating HistogramChart");
        }

        public void Display()
        {
            Console.WriteLine("Displaying HistogramChart");
        }

    }
}
