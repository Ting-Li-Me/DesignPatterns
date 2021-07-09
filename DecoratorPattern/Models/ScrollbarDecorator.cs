namespace DecoratorPattern.Models
{
    using System;
    class ScrollbarDecorator:ComponentDecorator
    {
        public ScrollbarDecorator(VisualComponent component):base(component)
        { }

        public override void Display()
        {
            this.SetScrollbar();
            base.Display();
        }

        private void SetScrollbar()
        {
            Console.WriteLine("Add scroll bar for component");
        }

    }
}
