using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public abstract class LogStrategy
    {
        public abstract bool DoLog(string content);
        public bool Log(string app, string key, string content)
        {
            return DoLog(app + key + content);
        }
    }
}
