using System;

namespace MethodOverriding
{   
    // can override because Draw() method is set to virtual 
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }

    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }
    public class Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public Position position { get; set; }
        public ShapeType Type { get; set; }
        public virtual void Draw()
        {

        }
    }
}
