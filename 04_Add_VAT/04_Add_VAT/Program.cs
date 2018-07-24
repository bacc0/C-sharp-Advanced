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
                            .Select(s => double.Parse(s) * 1.20)
                            .ToList()
                   .ForEach(vatS => Console.WriteLine($"{vatS:f2}"));


        }
    }
}
