using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.MultipleDb
{
    public abstract class DbAbstractFactory
    {
        public abstract IDbConnection CreateConnection(string conString);
        public abstract IDbCommand CreateCommand(IDbConnection con, string command);

        public abstract IDataAdapter CreateDbAdapter(IDbCommand cmd);
        public abstract IDataReader CreateDbReader(IDbCommand cmd);
    }
}
