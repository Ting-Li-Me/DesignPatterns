namespace AbstractFactoryPattern.Interfaces
{
    interface ISkinFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        IComboBox CreateComboBox();
    }
}
