using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {   // var shape = new Shape() won't complied -> inconstantiated
            var circle = new Circle();
            circle.Draw();
            circle.Copy();
        }
    }
}
