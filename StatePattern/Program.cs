namespace StatePattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Jack", 0);
            acc.Deposit(1000);
            acc.Withdraw(2000);
            acc.Deposit(3000);
            acc.Withdraw(4000);
            acc.Withdraw(1000);

            acc.ComputeInterest();

            Console.ReadLine();

        }
    }
}
