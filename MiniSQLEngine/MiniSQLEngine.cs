using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniSQLEngine
{
    public class Parser
    {
        public static MiniSQLQuery Parse(string query)
        {
            Match match;
            match = Regex.Match(query, RegularExpressions.SelectAll);
            if (match.Success)
            {
                return new MiniSQLSelectAll(match.Groups[1].Value);
            }

            //...

            return null;
        }
    }
}
