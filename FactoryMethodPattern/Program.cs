namespace FactoryMethodPattern
{
    using System;
    using Models;
    using Interfaces;
    class Program
    {
        static void Main(string[] args)
        {

            ILoggerFactory loggerFactory;
            ILogger logger;
            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {

                var type = input;

                if (type.ToLower() == "db")
                {
                    loggerFactory = new DBLoggerFactory();
                    logger = loggerFactory.CreateLogger();
                    logger.WriteLog();
                }
                else if (type.ToLower() == "file")
                {
                    loggerFactory = new FileLoggerFactory();
                    logger = loggerFactory.CreateLogger();
                    logger.WriteLog();
                }



            }


        }
    }
}
