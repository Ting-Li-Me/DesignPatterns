namespace AbstractFactoryPattern.Factories
{
    using Interfaces;
    using Models;
    class SpringSkinFactory:ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }

        public IComboBox CreateComboBox()
        {
           return new SpringComboBox();
        }

       
    }
}
