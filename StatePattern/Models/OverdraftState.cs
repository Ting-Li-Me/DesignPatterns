namespace StatePattern.Models
{
    using System;
    class OverdraftState : AccountState
    {
        public OverdraftState(AccountState state)
        {
            this.Acc = state.Acc;
        }

        public override void Deposit(double amount)
        {
            Acc.Balance += amount;
            StateCheck();
        }

        public override void Withdraw(double amount)
        {
            Acc.Balance -= amount;
            StateCheck();
        }

        public override void ComputeInterest()
        {
            Console.WriteLine("Compute interest.");
        }



        public override void StateCheck()
        {
            if (Acc.Balance > 0)
            {
                Acc.SetState(new NormalState(this));
            }
            else if (Acc.Balance == -2000)
            {
                Acc.SetState(new RestrictedState(this));
            }
            else if (Acc.Balance < -2000)
            {
                Console.WriteLine("Limited Account!");
            }
        }
    }
}
