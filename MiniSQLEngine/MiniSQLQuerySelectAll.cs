using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQLEngine
{
    public class MiniSQLSelectAll : MiniSQLQuery
    {
        string Table;

        public MiniSQLSelectAll(string table)
        {
            Table = table;
        }

        public override string Run(Database db)
        {
            return db.SelectAll(Table);
        }
    }
}
