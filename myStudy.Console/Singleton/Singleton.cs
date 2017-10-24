using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console
{
    public  class Singleton
    {
        static readonly Singleton _instance = new Singleton();

        static Singleton()
        {        }

        public static Singleton Instance { get { return _instance; } }

        readonly SomeConfig _config = new SomeConfig();
        public  SomeConfig Config { get { return _config; } }
       

        private Singleton()
        {

        }

        
    }
}
