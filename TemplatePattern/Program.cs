namespace TemplatePattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            string input = string.Empty;
            string type = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                type = input;

                if (type == "saving")
                {
                    account = new SavingAccount(); 
                }
                else if (type == "fixed")
                {
                    account = new FixedTermAccount();
                }
                else
                {
                    continue;
                }

                account.Handle("Jack", "Pass");

            }

        }
    }
}
