using System;
using System.Collections.Generic;
using System.Text;

namespace PriceChecker.Common
{

    public class FieldType
    {
        public string FieldName { get; set; }
    }


    public class Fields
    {
        public List<FieldType> Types { get; set; }

        public Fields()
        {
            Types = new List<FieldType>();
        }
    }

    public class SupplierFiles
    {
        public string NameSupplier;
        public string NamePriceFile;
    }
}
