using System;
using System.Collections.Generic;
using System.Text;

namespace myStudy.ConsoleApp.LoggingLibrary
{
    public class DbContentWriter : BaseContentWriter
    {
        private string _connString = @"DataSource=./log.db";
        
        public override bool WriteToMedia(string content)
        {
            SqlAccess sqlAccess = new SqlAccess(_connString);

            if (sqlAccess.Open())
            {
                string query = "insert into log values('"+content+ "');";

                var res = sqlAccess.ExecuteNonQuery(query);
                sqlAccess.Close();

                return res;
                 
            }

            return false;
        }
    }

    
}
