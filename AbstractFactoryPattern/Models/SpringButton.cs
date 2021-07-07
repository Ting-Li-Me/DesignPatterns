namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SpringButton:IButton
    {
        public void Display()
        {
            Console.WriteLine("Displaying green button");
        }
    }
}
