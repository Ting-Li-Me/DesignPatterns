namespace MementoPattern
{
    using Models;
    using System;
    class Program
    {
        public static void Display(Chessman chessman)
        {
            Console.WriteLine($"Chess {chessman.Label} is on position - X:{chessman.X} Y:{chessman.Y} ");
        }

        static void Main(string[] args)
        {
            MementoCaretaker mc = new MementoCaretaker();
            Chessman chess = new Chessman("A", 1, 2);
            Display(chess);
            mc.SetMemento(chess.Save());

            chess.Y = 4;
            Display(chess);
            mc.SetMemento(chess.Save());
            Display(chess);

            chess.Y = 5;
            Display(chess);
            Console.WriteLine("Get back to previous step.");
            chess.Restore(mc.GetMemento());
            Display(chess);

            Console.ReadLine();
        }
    }
}
