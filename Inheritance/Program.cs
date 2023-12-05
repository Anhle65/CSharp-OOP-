using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Inheritance
{
    class Program
    {
        //Conversion from derived class to base class
        static void DerivedToBase()
        {
            /* shape and text point to the same memory stored that object
            shape has limited view of object rather than text (exclude FontSize and FontName) */
            Text text = new Text();
            Shape shape = text;
            text.width = 200;
            shape.height = 100;
            Console.WriteLine(shape.height);
            Console.WriteLine(shape.width);
        }
        public void Upcasting()
        {
            // Upcasting
            /* The argument pass in to the constructor can be in the derived class of the base object class (Stream) 
               MemoryStream is in the Stream class*/
            StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            // can pass any type objects (int, string, text object)
            list.Add(1);
            list.Add(new Text());
            // generic class: all element is in the type we set 
            var anotherlist = new List<int>();
        }
        static void Main(string[] args)
        {
            // Downcasting
            /* Using in build application
             * (Button_Click(object sender,...), which pass object sender as an argument of click handler,
             * only when downcasting to access the properties of button
             * var button = (Button) sender;  works when sure its method (click handler)
             * else using 'as' keyword
             * var button = sender as Button;
             * if (button != null) .....
            */
            Shape shape = new Text();
            Text text = (Text) shape;
            // shape now can access to FontSize and FontName
        }
    }
}
