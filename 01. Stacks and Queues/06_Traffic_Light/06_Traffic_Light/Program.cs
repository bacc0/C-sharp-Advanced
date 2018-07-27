using System;
using System.Collections.Generic;

namespace _Traffic_Light
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cars = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            var carsQueue = new Queue<string>();

            while ( input != "end")
            {
                if (input == "green")
                {
                    var carsCanPast = carsQueue.Count;

                    for (int i = 0; i < Math.Min(cars, carsCanPast); i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                    }
                }
                carsQueue.Equals(input);

                input = Console.ReadLine();
            }
        }
    }
}
