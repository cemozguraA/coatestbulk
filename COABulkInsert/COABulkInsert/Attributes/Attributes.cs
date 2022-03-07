using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COABulkInsert.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class bigint : Attribute
    {
        private string name;
        public int Lenght;

        public bigint(string name)
        {
            this.name = name;
            Lenght = 50;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class binary : Attribute
    {
        private string name;
        public int Lenght;

        public binary(string name)
        {
            this.name = name;
            Lenght = 50;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class bit : Attribute
    {
        private string name;

        public bit(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Char : Attribute
    {
        private string name;
        public int Lenght;

        public Char(string name)
        {
            this.name = name;
            Lenght = 50;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class date : Attribute
    {
        private string name;

        public date(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class datetime : Attribute
    {
        private string name;

        public datetime(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Decimal : Attribute
    {
        private string name;
        public int precision;
        public int scale;

        public Decimal(string name)
        {
            this.name = name;
            this.precision = 18;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Float : Attribute
    {
        private string name;
        public Float(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Int : Attribute
    {
        private string name;
        public Int(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class money : Attribute
    {
        private string name;
        public money(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class nchar : Attribute
    {
        public  int _Lenght { get; set;  }
        private string name;
        //public int Lenght;
        public nchar(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class numeric : Attribute
    {
        private string name;
        public int precision;
        public int scale;

        public numeric(string name)
        {
            this.name = name;
            this.precision = 18;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class nvarchar : Attribute
    {
        private string name;
        public int Lenght;
        public nvarchar(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class varchar : Attribute
    {
        private string name;
        public int Lenght;
        public varchar(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class varbinary : Attribute
    {
        private string name;
        public int Lenght;
        public varbinary(string name)
        {
            this.name = name;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class uniqueidentifier : Attribute
    {
        private string name;
        public uniqueidentifier(string name)
        {
            this.name = name;
        }
    }

}
