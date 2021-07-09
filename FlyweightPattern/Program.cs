namespace FlyweightPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            IgoChessman blk1, blk2, blk3, wht1, wht2;
            IgoChessmanFactory factory;

            factory = IgoChessmanFactory.GetInstance();

            blk1 = factory.GetIgochessman("b");
            blk2 = factory.GetIgochessman("b");
            blk3 = factory.GetIgochessman("b");
            Console.WriteLine($"black chess piece instances are same? {blk1 == blk3}");

            wht1 = factory.GetIgochessman("w");
            wht2 = factory.GetIgochessman("w");
            Console.WriteLine($"white chess piece instances are same? {wht1 == wht2}");

            blk1.Display(new Coordinates(1,2));
            blk2.Display(new Coordinates(3, 4));
            blk3.Display(new Coordinates(5, 6));
            wht1.Display(new Coordinates(7, 8));
            wht2.Display(new Coordinates(9, 0));

            Console.ReadLine();

        }
    }
}
