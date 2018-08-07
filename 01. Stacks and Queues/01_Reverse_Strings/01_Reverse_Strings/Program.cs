using System;
using System.Collections.Generic;

namespace _Reverse_Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            Stack<char> reversed = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reversed.Push(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(reversed.Pop());
            }
        }
    }
}
