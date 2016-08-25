using System;
using GenericList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void Slice__Handles_Length_Out_Of_Bound()
        {
            int[] input = {1, 2, 3, 4, 5};
            int start = 2;
            int length = 10;
            int[] expected = {3, 4, 5};

            int[] actual = input.Slice(start, length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Slice__Slices_Array()
        {
            int[] input = {1, 2, 3, 4, 5};
            int start = 1;
            int length = 3;
            int[] expected = {2, 3, 4};

            int[] actual = input.Slice(start, length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Slice__Start__End__Handles_Zero_Length()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int start = 1;
            int length = 0;
            int[] expected = { };

            int[] actual = input.Slice(start, length);

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
