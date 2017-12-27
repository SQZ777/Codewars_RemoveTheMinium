using System;
using System.Collections.Generic;
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
    }

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
