namespace FactoryMethodPattern.Models
{
    using Interfaces;
    using System;
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File Log.");
        }
    }
}
