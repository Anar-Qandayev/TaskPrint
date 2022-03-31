using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Word : IPrintable
    {
        public int WordCount { get; set; }
        public string Filename { get ; set; }
        public Word( string Filename , int WordCount) 
        {
            this.WordCount = WordCount;
            this.Filename = Filename;
        }
        public string Print()
        {
            if (WordCount<1&&Filename==null)
            {
                return "Deyer daxil edin!";
            }
            return $"File name: {Filename}\nWord count :{WordCount} ";
        }
    }
}
