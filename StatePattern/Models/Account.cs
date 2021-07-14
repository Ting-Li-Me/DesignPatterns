namespace StatePattern.Models
{
    using System;
    class Account
    {
        private AccountState state;
        private string owner;
        private double balance = 0;

        public Account(string owner, double init)
        {
            this.owner = owner;
            this.balance = init;
            this.state = new NormalState(this);
            Console.WriteLine($"{this.owner} opens an account, init amount is {this.balance}");
            Console.WriteLine("-----------------------");
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void SetState(AccountState state)
        {
            this.state = state;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"{this.owner} deposited {amount}");
            state.Deposit(amount);
            Console.WriteLine($"Balance is {this.balance}");
            Console.WriteLine($"Account state is {this.state.GetType().ToString()}");
            Console.WriteLine("-----------------------------");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"{this.owner} withdrew {amount}");
            state.Withdraw(amount);
            Console.WriteLine($"Balance is {this.balance}");
            Console.WriteLine($"Account state is {this.state.GetType().ToString()}");
            Console.WriteLine("-----------------------------");
        }

        public void ComputeInterest()
        {
            state.ComputeInterest();
        }

    }
}
