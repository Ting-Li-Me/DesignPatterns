namespace FactoryMethodPattern.Models
{
    using Interfaces;
    using System;
    class DBLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database Log.");
        }
    }
}
