using System;
using System.Linq;

namespace _Sort_Even_Numbers
{
    class MainClass
    {
        private const int V = 2;

        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                               .Split(", ".ToCharArray()
                                      ,StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .Where(n => n % 2 == 0)
                               .OrderBy(x => x)
                               .ToArray();
            
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
