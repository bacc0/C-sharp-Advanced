using System;
using System.Collections.Generic;

namespace _Reverse_Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(5); 
            numbers.Push(7); 
            numbers.Push(2);

            int cn = numbers.Peek();
             Console.WriteLine(cn);

        }
    }
}
