using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class QueryResult
    {
        public DataTable DataTable { get; set; }
        public string Message { get; set; }
        public string OnCompleteMessage { get; set; }

    }
}
