namespace TemplatePattern.Models
{
    using System;
    abstract class Account
    {
        private bool Validate(string account, string password)
        {
            Console.WriteLine($"Account:{account}");
            Console.WriteLine($"Password: {password}");

            if (account =="Jack" && password == "Pass")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected abstract void CalculateInterest();

        private void Display()
        {
            Console.WriteLine("Display Interest!");
        }

        public void Handle(string account, string password)
        {
            if (!Validate(account, password))
            {
                Console.WriteLine("Account or Password error!");
                return;
            }
            CalculateInterest();
            Display();
        }

    }
}
