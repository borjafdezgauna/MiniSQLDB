﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQLEngine
{
    public abstract class MiniSQLQuery
    {
        public abstract string Run(Database db);
    }
}
