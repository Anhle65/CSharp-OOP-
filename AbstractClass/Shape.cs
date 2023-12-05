using System;

namespace AbstractClass
{   
    //abstract method must inside an abstract class
    public abstract class Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        // abstract is only declared 
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard");
        }
    }
}
