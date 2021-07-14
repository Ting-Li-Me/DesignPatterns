namespace StatePattern2.Models
{
    using System;
    class OnState : SwitchState
    {
        public override void On(Switch s)
        {
            Console.WriteLine(" has already been turned ON");
        }

        public override void Off(Switch s)
        {
            Console.WriteLine(" : turn off the switch.");
            s.SetState(Switch.GetState("off"));
        }


    }
}
