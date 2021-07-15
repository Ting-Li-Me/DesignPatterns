namespace TemplatePattern.Models
{
    using System;
    class SavingAccount: Account
    {
        protected override void CalculateInterest()
        {
            Console.WriteLine("Calculate Interest for saving account");
        }
    }
}
