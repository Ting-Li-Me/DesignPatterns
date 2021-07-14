using System;

namespace StatePattern.Models
{
    class NormalState : AccountState
    {
        public NormalState(Account acc)
        {
            this.Acc = acc;
        }

        public NormalState(AccountState state)
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
            Console.WriteLine("Normal State, no interest needs to pay.");
        }

      

        public override void StateCheck()
        {
           if (Acc.Balance > -2000 && Acc.Balance <=0)
            {
                Acc.SetState(new OverdraftState(this));
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
