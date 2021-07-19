using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Models
{
    using System;
    using Interfaces;
    class Player : IObserver
    {
        public string Name { get; set; }
        public Player(string name)
        {
            this.Name = name;
        }

        public void Help()
        {
            Console.WriteLine($"Hold on, {this.Name} is coming!");
        }

        public void BeAttacked(AllyControlCenter acc)
        {
            Console.WriteLine($"{this.Name} is being attacked.");
            acc.NotifyObserver(this.Name);
        }
    }
}
