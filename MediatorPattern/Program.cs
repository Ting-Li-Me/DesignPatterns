namespace MediatorPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            Button addBT = new Button();
            List list = new List();
            ComboBox cb = new ComboBox();
            TextBox usernameTB = new TextBox();

            addBT.SetMediator(mediator);
            list.SetMediator(mediator);
            cb.SetMediator(mediator);
            usernameTB.SetMediator(mediator);

            mediator.AddButton = addBT;
            mediator.List = list;
            mediator.ComboBox = cb;
            mediator.UsernameTextBox = usernameTB;

            addBT.Changed();
            Console.WriteLine("---------------------------------");

            list.Changed();

            Console.ReadLine();
        }

    }
}
