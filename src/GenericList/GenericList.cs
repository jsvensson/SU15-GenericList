using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        private T[] items;

        public int Count { get; private set; }

        public GenericList()
        {
            items = new T[0];
        }

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public void Add(T value)
        {
            CheckCapacity(Count + 1);
            items[items.Length - 1] = value;
            Count++;
        }

        private void CheckCapacity(int size)
        {
            if (items.Length <= size - 1)
            {
                T[] newItems = new T[Count + 1];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
        }

    }
}
