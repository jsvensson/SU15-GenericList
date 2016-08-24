using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GenericList
{
    public static class ArrayExtensions
    {
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            int length = end - start + 1;
            T[] slice = new T[length];

            for (int i = 0; i < length; i++)
            {
                slice[i] = source[start + i];
            }

            return slice;
        }

        public static T[] Slice<T>(this T[] source, int end)
        {
            return Slice(source, 0, end);
        }
    }
}
