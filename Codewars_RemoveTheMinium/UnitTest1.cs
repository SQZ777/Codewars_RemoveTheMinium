using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_RemoveTheMinium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_NothingArray_Should_Be_NothingArray()
        {
            CollectionAssert.AreEqual(new List<int>(), Remover.RemoveSmallest(new List<int>()));
        }

        [TestMethod]
        public void Input_1_Should_Be_NothingArray()
        {
            CollectionAssert.AreEqual(new List<int>(), Remover.RemoveSmallest(new List<int> { 1 }));
        }

        [TestMethod]
        public void Input_12_Should_Be_2()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, Remover.RemoveSmallest(new List<int> { 1, 2 }));
        }
    }

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return new List<int>();
            }
            var findMin = numbers.Min();
            var minIndex = numbers.FindIndex(x => x == findMin);
            numbers.RemoveAt(minIndex);
            return numbers;
        }
    }
}
