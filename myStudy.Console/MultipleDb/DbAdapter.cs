using myStudy.Console.LoggingLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.MultipleDb
{
    public class DbAdapter : IDbAdapter
    {
        readonly ObjectFactory _of = new ObjectFactory();
        readonly DbAbstractFactory _daf = null;

        readonly string _connString;

        IDbConnection _dbConn;
        IDbCommand _dbComm;

        public DbAdapter(string driver, string connString)
        {
            _of.Get(driver, "prototype");
            _connString = connString;
        }

        public bool Close()
        {
            throw new NotImplementedException();
        }

        public DataSet Execute(string query)
        {
            try
            {
                if (_dbConn == null)
                    return null;

                _dbComm = _daf.CreateCommand(_dbConn, query);
                var dataAdapter = _daf.CreateDbAdapter(_dbComm);

                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                return dataset;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public bool ExecuteNonQuery(string query)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public bool Open()
        {
            try
            {
                _dbConn = _daf.CreateConnection(_connString);
                if (_dbConn == null)
                    return false;

                _dbConn.Open();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
