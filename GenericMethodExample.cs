using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class GenericMethodExample<T>
    {
        private T[] _data = new T[10];
        //passing generic parameters to a method
        public void Method1(int index,T Name)
        {
            if (index >= 0 && index < 10)
                _data[index] = Name;
        }
        //other generic method ways- it can be a mix of normal and generic parameters
        public T Method2(T value1, T value2)
        {
            return value1;

        }
        public T Method3(T value1,  int value2)
        {
            return value1;
        }
        public T Method4(T value)
        {
            return value;
        }
    }
    class 

}
