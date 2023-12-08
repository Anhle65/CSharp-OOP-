using System;
using System.Collections.Generic;

namespace MethodOverriding
{   

    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            // add a new shape 
            shapes.Add(new Circle());
            shapes.Add(new Triangle());
            
            var canvas = new Canvas();
            
            canvas.DrawShapes(shapes);
            //Console.WriteLine("Hello World!");
        }
    }
}
