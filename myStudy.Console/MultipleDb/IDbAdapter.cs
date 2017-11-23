using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.MultipleDb
{
    public interface IDbAdapter
    {
        bool Open();
        DataSet Execute(string query);
        IDataReader ExecuteQuery(string query);
        bool ExecuteNonQuery(string query);
        bool Close();
    }
}
