using System;
using System.Collections.Generic;
using System.Linq;

namespace _Filter_by_Age
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var people = new Dictionary<string, int>();

            var rot = int.Parse(Console.ReadLine());

            for (int i = 0; i < rot; i++)
            {
                var input = Console.ReadLine().Split(", ".ToCharArray()
                                                     ,StringSplitOptions
                                                     .RemoveEmptyEntries);

                var person = input[0];
                var years  = int.Parse(input[1]);

                if ( !people.ContainsKey(person))
                {
                    people.Add(person, years);
                }
            }
            var oldYoung = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());   
            var name = Console.ReadLine();

            if (true)
            {

            }

        }
    }
}
