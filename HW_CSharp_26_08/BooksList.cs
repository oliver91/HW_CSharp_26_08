using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp_26_08
{
    class BooksList<T>
    {
        private T[] array = new T[5];
        private int lastIndex = 0;

        public int ElementsCount
        {
            get { return lastIndex; }
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public void Add(T el)
        {
            if (lastIndex > array.Length - 1)
            {
                T[] tmp = new T[array.Length];
                array.CopyTo(tmp, 0);
                array = new T[array.Length + 1];
                tmp.CopyTo(array, 0);
            }
            array[lastIndex] = el;
            lastIndex++;
        }

        public T[] Remove(T el)
        {
            int index = 0;
            bool notFound = true;
            T[] newArray = new T[lastIndex-1]; 
            for (int i = 0; i < lastIndex; i++)
            {
                if (array[i].Equals(el))
                {
                    index = i;
                    notFound = false;
                }
            }
            if (notFound != true)
            {
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }
                for (int i = index; i < newArray.Length; i++)
                {
                    newArray[i] = array[i + 1];
                }
            }
            return newArray;
        }

    }
}
