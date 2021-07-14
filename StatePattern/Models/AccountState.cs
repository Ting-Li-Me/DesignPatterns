namespace StatePattern.Models
{
    abstract class AccountState
    {
        public Account Acc { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void ComputeInterest();
        public abstract void StateCheck();
    }
}
