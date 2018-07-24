using System;
using System.Linq;

namespace _Count_Uppercase_Words
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                               .Split()
                               .ToList()
                               .Where(w => w.StartsWith("A"));

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
