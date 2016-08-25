using System;
using System.Linq;
using GenericList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GenericListTests
    {
        [TestMethod]
        public void GenericList__Add_Single_Item_To_Empty_List()
        {
            var actual = new GenericList<int>();
            int expected = 1;
            actual.Add(1);

            Assert.AreEqual(actual[0], expected);
            Assert.IsTrue(actual.Count == 1);
        }

        [TestMethod]
        public void GenericList__Collection_Initializer()
        {
            var input = new GenericList<int> {1, 2, 3};
            int[] expected = {1, 2, 3};

            int[] actual = input.ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
