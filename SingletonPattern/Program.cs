namespace SingletonPattern
{
    using System;
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer lb1, lb2, lb3, lb4;

            lb1 = LoadBalancer.GetInstance();
            lb2 = LoadBalancer.GetInstance();
            lb3 = LoadBalancer.GetInstance();
            lb4 = LoadBalancer.GetInstance();

            lb1.AddServer("Server1");
            lb1.AddServer("Server2");
            lb1.AddServer("Server3");
            lb1.AddServer("Server4");

            if (lb1 == lb2 && lb2 == lb3&& lb3 == lb4)
            {
                Console.WriteLine("Pass");
            }

            Console.ReadLine();
        }
    }
}
