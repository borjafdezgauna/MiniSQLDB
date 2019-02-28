using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQLEngine
{
    public class Database
    {
        public string Name;
        public Database(string databaseName)
        {
            //open the database if it exists, new one otherwise
            Name = databaseName;
        }

        //Query methods
        public string SelectAll(string table)
        {
            return Constants.NotImplemented;
        }

        public string SelectSome(string table, List<string> columns)
        {
            return Constants.NotImplemented;
        }

        //....
    }
}
