namespace DecoratorPattern.Models
{
    using System;
    class BlackBorderDecorator:ComponentDecorator
    {
        public BlackBorderDecorator(ComponentDecorator component) : base(component) { }

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
