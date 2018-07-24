using System;
using System.Linq;

namespace _Sum_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                               .Split(new char[] { ',', ' ' }
                                      , StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            var sum = 0;
            
            foreach (var n in input)
            {
                sum += n;
            }
            Console.WriteLine(input.Length + "\n" + sum);
        }
    }
}
