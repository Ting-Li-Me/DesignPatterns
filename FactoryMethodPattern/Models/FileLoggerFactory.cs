namespace FactoryMethodPattern.Models
{
    using Interfaces;
    class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            ILogger logger = new FileLogger();
            return logger;
        }
    }
}
