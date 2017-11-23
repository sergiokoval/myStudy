using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.MultipleDb
{
    class SqlServerDbFactory : DbAbstractFactory, ISerializable
    {
        public override IDbCommand CreateCommand(IDbConnection con, string command)
        {
            return new SqlCommand(command, (SqlConnection)con);
        }

        public override IDbConnection CreateConnection(string conString)
        {
            if (!string.IsNullOrEmpty(conString))
            {
                return new SqlConnection(conString);
            }
            return null;
        }

        public override IDataAdapter CreateDbAdapter(IDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        public override IDataReader CreateDbReader(IDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
