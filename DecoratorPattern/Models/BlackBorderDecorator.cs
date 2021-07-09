namespace DecoratorPattern.Models
{
    using System;
    class BlackBorderDecorator:ComponentDecorator
    {
        public BlackBorderDecorator(VisualComponent component) : base(component) { }

        public override void Display()
        {
            this.SetBlackBorder();
            base.Display();
        }

        private void SetBlackBorder()
        {
            Console.WriteLine("Add Black Border for component");
        }
    }
}
