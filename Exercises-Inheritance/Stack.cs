using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercises_Inheritance
{
    public class Stack
    {
        public List<object> list = new List<object>();
        public void Push(object data)
        {
            list.Add(data);
            if (data == null)
            {
                throw new InvalidOperationException("Input is a null");
            }
        }
        public object Pop()
        {   
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            else
            {   
                object last_item = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return last_item;
            }
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
