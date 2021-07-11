namespace ProxyPattern.Models
{
    using System;
    class Logger
    {
        public void Log(string userId)
        {
            Console.WriteLine($"{userId} did a search");
        }
    }
}
