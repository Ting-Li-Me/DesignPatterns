namespace ObserverPattern.Models
{
    using System;
    using Interfaces;
    class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName)
        {
            Console.WriteLine($"{allyName} Created.");
            Console.WriteLine("-------------------------------------------");
            this.allyName = allyName;
        }

        public override void NotifyObserver(string name)
        {
            Console.WriteLine($"{this.allyName} message: ally {name} gets attacted!");

            foreach (var obs in players)
            {
                if (((IObserver)obs).Name != name)
                {
                    ((IObserver)obs).Help();
                }
            }
        }
    }
}
