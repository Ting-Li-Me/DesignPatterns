namespace TemplatePattern.Models
{
    using System;
    class FixedTermAccount : Account
    {
        protected override void CalculateInterest()
        {
            Console.WriteLine("Calculate Interest for Fixed Term account");
        }
    }
}
