using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public class LoggerFactory
    {
        private static ObjectFactory _objectFactory = new ObjectFactory();

        public static LogStrategy CreateLogStrategy(string type)
        {
            return (LogStrategy) _objectFactory.Get(type);
        }
    }
}
