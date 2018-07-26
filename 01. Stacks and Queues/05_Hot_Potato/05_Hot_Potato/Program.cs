using System;
using System.Collections.Generic;

namespace _Hot_Potato
{
    class MainClass
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split();
            var tossLimit = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);

            while (queue.Count != 1)
            {
                for (int i = 1; i < tossLimit; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
