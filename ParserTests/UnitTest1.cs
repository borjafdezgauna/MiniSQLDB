using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParserTests
{
    [TestClass]
    public class ParserTest1
    {
        [TestMethod]
        public void SelectAll()
        {
            string [] wrongQueries = { "Select * FROM Table1;", "SELECT * FROM Table 1;", "SELECT * FROM Table1", "SELECT column1 FROM Table1;" };
            string [] correctQueries = { "SELECT * FROM Table1;", "SELECT  * FROM Table1 ;"};

            foreach (string query in wrongQueries)
                Assert.IsNull(MiniSQLEngine.Parser.Parse(query));


            foreach (string query in correctQueries)
                Assert.IsNotNull(MiniSQLEngine.Parser.Parse(query));
        }
    }
}
