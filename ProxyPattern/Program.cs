using System;

namespace ProxyPattern
{
    using System;
    using Interfaces;
    using Models;
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
