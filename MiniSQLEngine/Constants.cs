using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQLEngine
{
    class Constants
    {
        public const string NotImplemented = "Not implemented yet";
    }

    class RegularExpressions
    {
        public const string SelectAll = @"SELECT\s+\*\s+FROM\s+(\w+)\s*;";
    }
}
