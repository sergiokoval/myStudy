using myStudy.ConsoleApp.LoggingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.LoggingLibrary
{
    public class FileLogStrategy : LogStrategy
    {
        BaseContentWriter _writer = new FileContentWriter("someFile");

        public override bool DoLog(string content)
        {
            return _writer.Write(content).Result;
        }
    }
}
