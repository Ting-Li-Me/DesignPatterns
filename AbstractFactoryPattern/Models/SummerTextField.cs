namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SummerTextField:ITextField
    {
        public void Display()
        {
            Console.WriteLine("Displaying blue border TextField");
        }
    }
}
