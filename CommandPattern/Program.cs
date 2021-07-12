namespace CommandPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            FunctionButton fb = new FunctionButton();

            Command command, exitCommand = new ExitCommand(), helpCommand = new HelpCommand();

            string input = string.Empty;
            string type = string.Empty;

            while((input=Console.ReadLine().ToLower())!="end")
            {
                type = input;

                if (type=="exit")
                {
                    command = exitCommand;
                }
                else if (type == "help")
                {
                    command = helpCommand;
                }
                else
                {
                    continue;
                }

                fb.Command = command;
                fb.Click();
            }
            
            
        }
    }
}
