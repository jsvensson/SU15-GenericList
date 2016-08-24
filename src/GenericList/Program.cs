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
            var numberList = new GenericList<int>();

            for (int i = 1; i <= 10; i++)
            {
                numberList.Add(i);
            }

            Console.WriteLine($"Number of items in list: {numberList.Count}");

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            Console.ReadKey();
        }
    }
}
