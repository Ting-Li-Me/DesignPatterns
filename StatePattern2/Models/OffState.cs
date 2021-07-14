namespace StatePattern2.Models
{
    using System;
    class OffState: SwitchState
    {
        public override void On(Switch s)
        {
            Console.WriteLine(" : turn on the switch.");
            s.SetState(Switch.GetState("on"));
        }

        public override void Off(Switch s)
        {
            Console.WriteLine(" has already been turned OFF");
        }
    }
}
