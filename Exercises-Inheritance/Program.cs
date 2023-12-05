using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exercises_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            try
            {
                stack.Push(1);
                stack.Push("");
                stack.Push("Vanh");
                stack.Push(2);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
             catch (InvalidOperationException ex)
            {
                Debug.WriteLine($"Error: {ex}");
            }
        }
    }
}
