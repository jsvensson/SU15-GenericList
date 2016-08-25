using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        private T[] items = new T[0];
        private const int InitialSize = 2;

        public int Count { get; private set; }
        public int Capacity => items.Length;

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public void Add(T value)
        {
            CheckCapacity(Count + 1);
            items[Count] = value;
            Count++;
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            T[] left = items.Slice(0, index - 1);
            T[] right = items.Slice(index + 1, items.Length - 1);

            T[] slicedItems = new T[items.Length - 1];
        
            // Add left slice
            for (int i = 0; i < left.Length; i++)
            {
                slicedItems[i] = left[i];
            }

            // Add right slice
            for (int i = 0; i < right.Length - 1; i++)
            {
                slicedItems[index + i] = right[i];
            }

            items = slicedItems;
            Count--;
        }

        private void CheckCapacity(int size)
        {
            do
            {
                // Initialize array if empty
                if (items.Length == 0)
                {
                    items = new T[InitialSize];
                }

                // Already items in array?
                if (items.Length <= size - 1)
                {
                    var newItems = new T[items.Length * 2];
                    Array.Copy(items, newItems, items.Length);
                    items = newItems;
                }
            } while (items.Length <= size -1);
        }

    }
}
