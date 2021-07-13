namespace ObserverPattern.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    abstract class AllyControlCenter
    {
        protected string allyName;
        protected IList<IObserver> players = new List<IObserver>();

        public void SetAllyName(string allyName)
        {
            this.allyName = allyName;
        }
        public string getAllyName ()
        {
            return this.allyName;
        }

        public void Join(IObserver obs)
        {
            Console.WriteLine($"{obs.Name} joined {allyName}");
            players.Add(obs);
        }

        public void Quit(IObserver obs)
        {
            Console.WriteLine($"{obs.Name} quited {allyName}");
            players.Remove(obs);
        }

        public abstract void NotifyObserver(string name);

       

    }
}
