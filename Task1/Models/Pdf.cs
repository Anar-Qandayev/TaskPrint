using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Pdf : IPrintable
    {
        public string Filename { get; set ; }
        public int PageCount { get; set ; }
        public Pdf(string Filename, int PageCount)
        {
            this.PageCount = PageCount;
            this.Filename = Filename;
        }
        public string Print()
        {
            if (PageCount<1&&Filename==null)
            {
                return "Deyer daxil edin!";
            }
            return $"File name: {Filename}\nPage count :{PageCount} ";
        }
    }
}
