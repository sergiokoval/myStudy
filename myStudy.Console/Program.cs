using myStudy.ConsoleApp.LoggingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContentWriter writer = new DbContentWriter();
            writer.WriteToMedia("some text2");

            SqlAccess sa = new SqlAccess("DataSource=./log.db");

            System.Console.Write(sa.SelectQuery("select * from log;"));

            System.Console.Read();

        }
    }
}
