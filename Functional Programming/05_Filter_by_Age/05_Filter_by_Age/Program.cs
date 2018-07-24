using System;
using System.Collections.Generic;
using System.Linq;

namespace _Filter_by_Age
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>(peopleCount);

            for (int i = 0; i < peopleCount; i++)
            {
                var input = Console.ReadLine().Split(", ".ToCharArray()
                                                     , StringSplitOptions
                                                     .RemoveEmptyEntries);

                
                people.Add(input[0], int.Parse(input[1]));

            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            var filter = CreateFilter(condition, age);
            var printer = CreatePrinter(format);

            PrintPeople(people, filter, printer);

        }
        static void PrintPeople(Dictionary<string, int> people, 
                                Func<int, bool> filter, 
                                Action<KeyValuePair<string, int>> printer)
        {
            foreach (var p in people)
            {
                if (filter(p.Value))
                    printer(p);
            }
        }

        static Func<int, bool> CreateFilter(string condition, int age)
        {
            if (condition == "younger")
                return x => x < age;      
            
            else
                return x => x >= age;
        }

        static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            if (format == "name")
                return x => Console.WriteLine(x.Key);
            
            else if (format == "age")
                return x => Console.WriteLine(x.Value);
            
            else
                return x => Console.WriteLine($"{x.Key} - {x.Value}");
        }
    }
}
