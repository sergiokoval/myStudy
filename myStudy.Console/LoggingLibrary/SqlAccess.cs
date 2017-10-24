using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;


namespace myStudy.ConsoleApp.LoggingLibrary
{
    public class SqlAccess
    {
        string _connString;
        SQLiteConnection _connection = null;
        SQLiteTransaction _transaction = null;
        SQLiteCommand _command = null;

        public SqlAccess(string connString)
        {
            _connString = connString;
        }

        public string SelectQuery(string query)
        {
            Open();
            var selectCommand = new SQLiteCommand(query,_connection);

            var res = new StringBuilder();

            using (SQLiteDataReader reader = selectCommand.ExecuteReader())
            {
               
                while(reader.Read())
                {
                    res.Append(reader.GetValue(0)+Environment.NewLine);
                }
            }

            Close();

            return res.ToString();

         }

        public bool Open(bool useTransaction = false)
        {
            try
            {
                _connection = new SQLiteConnection(_connString);
                _connection.Open();

                if (useTransaction)
                {
                    _transaction = _connection.BeginTransaction();
                }

                return true;
            }
            catch(SQLiteException se)
            {
                System.Console.WriteLine(se.Message);
                return false;

            }            
        }

        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                //var query = "create table log(value varchar(100) null);";                
                //var createTableCommand = new SQLiteCommand(query,_connection);
                //createTableCommand.ExecuteNonQuery();

                _command = new SQLiteCommand(sql, _connection);
                _command.ExecuteNonQuery();
                _connection.Close();
                return true;
            }
            catch(SQLiteException se)
            {
                System.Console.WriteLine(se.Message);
                return false;
            }
        }

        public bool Close()
        {
            if(_connection !=null)
            {
                if(_transaction !=null)
                {
                    _transaction.Commit();
                    _transaction = null;
                }

                _connection.Close();
                _connection = null;
                return true;
            }
            return true;
        }
    }
}
