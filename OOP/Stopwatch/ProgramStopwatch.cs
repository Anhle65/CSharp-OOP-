using System;
using System.Diagnostics;

namespace OOP
{
    class Programs
    {
        static void Main()
        {
            var clock = new Stopwatch();
            clock.Start();
            var input = Console.ReadLine();
            Console.WriteLine("your enter is: " + input);
            clock.Stop();
            Console.WriteLine("Duration: " + clock.Duration);
        }
    }
}
