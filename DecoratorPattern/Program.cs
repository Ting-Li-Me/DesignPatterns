namespace DecoratorPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            VisualComponent component, componentSB;
            component = new Window();
            componentSB = new ScrollbarDecorator(component);
            componentSB.Display();

            Console.ReadLine();
        }
    }
}
