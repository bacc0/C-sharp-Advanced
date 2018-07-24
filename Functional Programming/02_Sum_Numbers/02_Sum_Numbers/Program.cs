using System;
using System.Linq;

namespace _Sum_Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                 .Split(new char[] { ',', ' ' }
                                      , StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();
            
            Console.WriteLine(numbers.Count + "\n" + numbers.Sum());
        }
    }
}
