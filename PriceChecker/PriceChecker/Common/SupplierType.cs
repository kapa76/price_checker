using System;
using System.Collections.Generic;
using System.Text;

namespace PriceChecker.Common
{
    public class Cell
    {
        public int Row;
        public int Col;
        public string Name;
    }

    public class SupplierType
    {
        public string Name;
        public List<Cell> ListCell;
        public SupplierType()
        {
            ListCell = new List<Cell>();
        }
    }
}
