using System;
using System.Linq;

namespace _Count_Uppercase_Words
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine()
                               .Split()
                               .Where(w => w[0].ToString() == 
                                      w[0].ToString().ToUpper())
                               .ToList();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
