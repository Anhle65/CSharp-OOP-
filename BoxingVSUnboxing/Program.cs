using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingVSUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Boxing since we add diff type object
            var list = new ArrayList();
            list.Add(1);
            list.Add(DateTime.Now);
            // Unboxing since we use genetic list (only 1 type of data)
            var anotherlist = new List<int>();
            anotherlist.Add(1);
            anotherlist.Add(5);
        }
    }
}
