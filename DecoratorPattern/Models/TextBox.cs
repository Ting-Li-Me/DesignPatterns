namespace DecoratorPattern.Models
{
    using System;
    class TextBox:VisualComponent
    {
        public override void Display()
        {
            Console.WriteLine("Displaying text box");
        }
    }
}
