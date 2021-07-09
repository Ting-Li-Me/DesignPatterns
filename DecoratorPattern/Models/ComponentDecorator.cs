namespace DecoratorPattern.Models
{
    class ComponentDecorator : VisualComponent
    {
        private VisualComponent component;

        public ComponentDecorator(VisualComponent component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}