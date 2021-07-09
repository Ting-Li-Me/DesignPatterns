namespace DecoratorPattern.Models
{
    using System;
    class ListBoxcs:VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("Displaying list box");
        }
    }
}
