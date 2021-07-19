namespace ObserverPattern
{
    using Interfaces;
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            AllyControlCenter acc = new ConcreteAllyControlCenter("The Team");

            IObserver player1, player2, player3, player4;

            player1 = new Player("Jack");
            acc.Join(player1);

            player2 = new Player("John");
            acc.Join(player2);

            player3 = new Player("Smith");
            acc.Join(player3);

            player4 = new Player("Mark");
            acc.Join(player4);

            player1.BeAttacked(acc);

            Console.ReadLine();

        }
    }
}
