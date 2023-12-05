using System;

namespace Program
{
    class Programs
    {
        static void Main()
        {
            var clock = new Stopwatch();
            clock.Start();
            Console.ReadLine();
            clock.Stop();
            Console.WriteLine(clock.Duration());

        }
    }
}