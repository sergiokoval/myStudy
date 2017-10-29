using myStudy.ConsoleApp.LoggingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console
{
    class SomeDelegateTestClass : ICloneable
    {
        public delegate void DoSmth();

        public DoSmth OnDoSmth;

        void Do()
        {
            OnDoSmth += this.Do;
        }

        public object Clone()
        {
            return new SomeDelegateTestClass();
        }
    }
        


    class Program
    {
        static void Main(string[] args)
        {
            SomeDelegateTestClass sc = new SomeDelegateTestClass();

            SomeDelegateTestClass newd = (SomeDelegateTestClass) sc.Clone();

            sc.OnDoSmth += () => { };

            DbContentWriter writer = new DbContentWriter();
            writer.WriteToMedia("some text2");

            SqlAccess sa = new SqlAccess("DataSource=./log.db");

            System.Console.Write(sa.SelectQuery("select * from log;"));

            System.Console.Read();

        }
    }
}
