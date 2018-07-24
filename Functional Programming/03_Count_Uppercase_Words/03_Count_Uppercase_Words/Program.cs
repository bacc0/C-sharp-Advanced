using System;
using System.Linq;

namespace _Count_Uppercase_Words
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Func<string, bool> checker = w => char.IsUpper(w[0]);

            Console.ReadLine()
                   .Split(new char[] {' '}
                      , StringSplitOptions
                        .RemoveEmptyEntries)
                   .Where(checker)
                   .ToList()
                   .ForEach( w => Console.WriteLine(w));
        }
    }
}
