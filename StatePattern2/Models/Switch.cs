namespace StatePattern2.Models
{
    using System;
    class Switch
    {
        public static SwitchState currentState, onState, offState;
        private string name;

        static Switch()
        {
            onState = new OnState();
            offState = new OffState();
            currentState = onState;
        }

        public Switch(string name)
        {
            this.name = name;
        }

        public void SetState(SwitchState state)
        {
            currentState = state;
        }

        public static SwitchState GetState(string type)
        {
            if (type.Equals("on"))
            {
                return onState;
            }
            else
            {
                return offState;
            }
        }

        public void On()
        {
            Console.Write(name);
            currentState.On(this);
        }

        public void Off()
        {
            Console.Write(name);
            currentState.Off(this);
        }


    }
}
