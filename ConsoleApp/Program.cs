using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var genericList = new GenericList<int>();

            for (int i = 1; i <= 10; i++)
            {
                genericList.Add(i);
            }

            Console.WriteLine($"Number of items in list: {genericList.Count}");
            Console.WriteLine($"List capacity: {genericList.Capacity}");
            for (int i = 0; i < genericList.Count; i++)
            {
                Console.WriteLine(genericList[i]);
            }

            Console.WriteLine($"Removing index 4 with value {genericList[4]}");
            genericList.RemoveAtIndex(4);

            Console.WriteLine($"Number of items in list: {genericList.Count}");
            Console.WriteLine($"List capacity: {genericList.Capacity}");
            for (int i = 0; i < genericList.Count; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Loop with foreach");
            foreach (var item in genericList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}
