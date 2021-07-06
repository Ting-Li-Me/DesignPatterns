namespace SimpleFactoryPattern
{
    using System;
    using Models;
    using Interfaces;
    class Program
    {
        static void Main(string[] args)
        {
            
            IChart chart;
            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {

                var type = input;

                chart = ChartFactory.GetChart(type);

                chart.Display();
            }
           

        }
    }
}
