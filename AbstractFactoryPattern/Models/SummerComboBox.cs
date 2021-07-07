namespace AbstractFactoryPattern.Models
{
    using Interfaces;
    using System;
    class SummerComboBox:IComboBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying blue border ComboBox");
        }
    }
}
