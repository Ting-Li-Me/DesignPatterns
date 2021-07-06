using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Models
{
    using Interfaces;
    class DBLoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            ILogger logger = new DBLogger();
            return logger;
        }
    }
}
