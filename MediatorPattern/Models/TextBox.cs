namespace MediatorPattern.Models
{
    using System;
    class TextBox:Component
    {
        public override void Update()
        {
            Console.WriteLine("Clean textbox after adding an item");
        }
        public void SetText()
        {
            Console.WriteLine("TextBox display: Angel");
        }
    }
}
