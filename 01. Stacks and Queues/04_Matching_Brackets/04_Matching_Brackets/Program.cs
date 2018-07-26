using System;
using System.Collections.Generic;

namespace _Matching_Brackets
{
    class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var stackBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackBrackets.Push(i);
                }
                if (input[i] == ')')
                {
                    var openBracketIndex = stackBrackets.Pop();
                    var length = i - openBracketIndex + 1;

                    Console.WriteLine(input.Substring(openBracketIndex, length));
                }
            }
        }
    }
}
