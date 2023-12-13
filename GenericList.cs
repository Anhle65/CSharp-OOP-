using System;

namespace Generics
{
    // <T>: represent the Type of data
    public class GenericList<T>
    {
        public void Add (T value)
        {

        }
        public T this[int index]
        {
            get 
            {
                throw new NotImplementedException();
            }
        }
    }
}
