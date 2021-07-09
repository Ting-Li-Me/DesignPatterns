namespace DecoratorPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            VisualComponent component, componentSB, componentBB;
            component = new Window();
            componentSB = new ScrollbarDecorator(component);
            componentBB = new BlackBorderDecorator(componentSB);
            componentBB.Display();

            Console.ReadLine();
        }
    }
}
