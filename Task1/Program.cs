using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome My Task");
            Excel ex = new Excel("",0,0);
            Console.WriteLine(ex.Print());
            PrintFile<int> print = new PrintFile<int>();          
            Console.WriteLine(print.Print());
            Console.WriteLine("-------------------------------");
            Word word = new Word("Book.txt",34);          
            Console.WriteLine(word.Print());
            Console.WriteLine(print.Print());
            Console.WriteLine("-------------------------------");
            Pdf pdf = new Pdf("Text.pdf",234);
            Console.WriteLine(pdf.Print());
            Console.WriteLine(print.Print());
            Console.WriteLine("-------------------------------");


        }
    }
    interface IPrintable
    {
        public string Filename { get; set; }
        public string Print();
    }
}
