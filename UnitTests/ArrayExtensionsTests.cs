using System;
using GenericList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void Slice__Slices_Array()
        {
            int[] input = {1, 2, 3, 4, 5};
            int start = 1;
            int end = 3;
            int[] expected = {2, 3, 4};

            int[] actual = input.Slice(start, end);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
