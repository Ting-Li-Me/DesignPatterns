namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SpringTextField:ITextField
    {
        public void Display()
        {
            Console.WriteLine("Displaying green border TextField");
        }
    }
}
