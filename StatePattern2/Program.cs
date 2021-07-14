namespace StatePattern2
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Switch s1, s2;
            s1 = new Switch("Switch 1");
            s2 = new Switch("Switch 2");

            s1.On();
            s2.On();
            s1.Off();
            s2.Off();
            s2.On();
            s1.On();

            Console.ReadLine();
        }
    }
}
