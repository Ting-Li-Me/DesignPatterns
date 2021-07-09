namespace DecoratorPattern.Models
{
    using System;
    class Window : VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("Displaying window");
        }
    }
}
