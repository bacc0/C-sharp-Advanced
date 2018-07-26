using System;
using System.Collections.Generic;

namespace _Simple_Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split();

            var stack = new Stack<string>();

            for (int counter = elements.Length - 1; counter >= 0; counter--)
            {
                stack.Push(elements[counter]);
            }

            while (stack.Count > 1)
            {
                var leftNum = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var rightNum = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+":
                        stack.Push((leftNum + rightNum)
                                   .ToString());
                        break;
                    case "-":
                        stack.Push((leftNum - rightNum)
                                   .ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
