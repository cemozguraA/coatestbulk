using COABulkInsert.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COABulkInsert
{
    public class COABulkInsert<T> : ICOABulkInsert<T> where T : class
    {
        public string ClassName { get; set; }
        public string SPName { get { return ClassName + "BulkInsert"; } }
        public COABulkInsert(string _className)
        {
            if (string.IsNullOrEmpty(_className))
                ClassName = typeof(T).Name;
            else
                ClassName = _className;
            ToDataTable();
        }

        public Task<bool> CreateSP()
        {



            var spcheckStr = $"SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[{SPName}]') AND type in (N'P', N'PC')";

            throw new NotImplementedException();
        }

        public Task<bool> CreateTableType()
        {
            var str = "TYPE_ID(N'MyType')";
            throw new NotImplementedException();
        }

        string ToDataTable()
        {
            StringBuilder createSp = new($"CREATE TYPE [dbo].[{ClassName}] AS TABLE(");
    //[Id] [int] NULL,
    //[Name] [varchar](100) NULL,
    //[Country] [varchar](50) NULL)");
//GO 
//CREATE PROCEDURE [dbo].[Insert_Customers]
//    @tblCustomers CustomerType READONLY AS BEGIN
//    SET NOCOUNT ON;
//    INSERT INTO Customers(CustomerId, Name, Country)
//    SELECT Id, Name, Country FROM @tblCustomers END");
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {

                var nullcontrl = Nullable.GetUnderlyingType(prop.PropertyType)==null?" NOT NULL,": "NULL,";
                var getAttributes = prop.GetCustomAttributes(false);
                foreach (var attribute in getAttributes)
                {
                    PropertyDescriptorCollection attributeproperties =
               TypeDescriptor.GetProperties(attribute.GetType());
                    foreach (var item in attributeproperties)
                    {
                        var aaa = item;
                    }
                }
            }
         
               

            return "";
        }
    }
}
