using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console
{
    public class SomeConfig
    {
        public string FileName { get; private set; }

        public SomeConfig()
        {
            FileName = "file.txt";
            System.Console.WriteLine("ctor config");
        }
    }
}
