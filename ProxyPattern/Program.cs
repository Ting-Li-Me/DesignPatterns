namespace ProxyPattern
{
    using Interfaces;
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            ISearcher searcher = new ProxySearcher();

            string result = searcher.DoSearch("validUser", "search key");

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
