namespace MediatorPattern.Models
{
    using System;
    class ComboBox:Component
    {
        public override void Update()
        {
            Console.WriteLine("Combobox added an item: Jack");
        }
        public void Select()
        {
            Console.WriteLine("an item selected from the Combobox: Angel");
        }
    }
}
