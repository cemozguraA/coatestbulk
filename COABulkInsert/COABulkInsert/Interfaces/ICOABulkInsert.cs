using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COABulkInsert.Interfaces
{
    public interface ICOABulkInsert<T> where T : class
    {
        public Task<bool> CreateTableType();
        public Task<bool> CreateSP();
        

    }
}
