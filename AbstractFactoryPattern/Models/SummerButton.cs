namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SummerButton:IButton
    {
        public void Display()
        {
            Console.WriteLine("Displaying blue button");
        }
    }
}
