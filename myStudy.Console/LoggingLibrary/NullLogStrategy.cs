using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public class NullLogStrategy : LogStrategy
    {
        public override bool DoLog(string content)
        {
            System.Console.WriteLine(content);
            return true;
        }
    }
}
