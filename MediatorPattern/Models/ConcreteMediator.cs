namespace MediatorPattern.Models
{
    using System;
    class ConcreteMediator : Mediator
    {
        public Button AddButton { get; set; }
        public List List { get; set; }
        public TextBox UsernameTextBox { get; set; }
        public ComboBox ComboBox { get; set; }

        public override void ComponentChanged(Component c)
        {
            if (c == AddButton)
            {
                Console.WriteLine("-- Click to add button");
                List.Update();
                ComboBox.Update();
                UsernameTextBox.Update();
            }
            else if (c == List)
            {
                Console.WriteLine("-- Select a user from the list");
                ComboBox.Select();
                UsernameTextBox.SetText();
            }
            else if (c == ComboBox)
            {
                Console.WriteLine("-- Select a user from the comboBox");
                ComboBox.Select();
                UsernameTextBox.SetText();
            }
        }


    }
}
