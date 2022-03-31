using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Excel : IPrintable
    {
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }

        public string Filename { get ; set ; }
        public Excel(string Filename,int ColumnCount ,int RowCount)
        {
            this.ColumnCount = ColumnCount;
            this.RowCount = RowCount;
            this.Filename = Filename;
           
        }
        public string Print()
        {
            if (ColumnCount < 1 && RowCount < 1 )
            {
                return "Deyer daxil edin!";
            }
          return $"File name: {Filename}\nColumn count:{ColumnCount} Row count: {RowCount}";
        }
    }
}
