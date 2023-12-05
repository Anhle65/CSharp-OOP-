using System;

namespace AbstractClass
{
    public class Circle : Shape
    {   
        // Must override all the abstract methods from base class
        // Can not be instantiated (var shape = new Shape() won't complied)
        // Benefits over than 'virtual': avoid risk when having new derived class from Shape but forget to override the method
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
