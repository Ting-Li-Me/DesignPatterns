namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SpringComboBox:IComboBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying green border ComboBox");
        }
    }
}
