using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseClientSQL
{
    public class QueryStorage
    {
        public string name;
        public string sqlQuery;
        public QueryStorage(string Name, string query)
        {
            name = Name;
            sqlQuery = query;
        }
    }
}
