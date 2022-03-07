using COABulkInsert.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestClass
    {
        [nchar("TestName",_Lenght = 10)]
        public int MyProperty { get; set; }
        [varchar("Test", Lenght = 20)]
        public int strinng { get; set; }
        public int? nullableint { get; set; }
    }
}
