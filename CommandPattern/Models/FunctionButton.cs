namespace CommandPattern.Models
{
    using System;
    class FunctionButton
    {
        public Command Command { get; set; }

        public void Click()
        {
            Console.WriteLine("Click Function Button");
            Command.Execute();
        }
    }
}
