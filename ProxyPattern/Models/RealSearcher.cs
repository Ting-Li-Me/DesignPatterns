namespace ProxyPattern.Models
{
    using System;
    using Interfaces;
    class RealSearcher : ISearcher
    {
        public string DoSearch(string userId, string keyword)
        {
            Console.WriteLine($"{userId} is doing a search with keyword '{keyword}' ");
            return "Search Result...";
        }
    }
}
