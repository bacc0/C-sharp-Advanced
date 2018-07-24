using System;
using System.Linq;

namespace _Add_VAT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ReadLine()
                   .Split(", ".ToCharArray()
                         , StringSplitOptions
                         .RemoveEmptyEntries)
                   .Select(x => double.Parse(x) * 1.20)
                   .ToList()
                   .ForEach(x => Console
                                 .WriteLine($"{x:f2}"));
        }
    }
}
