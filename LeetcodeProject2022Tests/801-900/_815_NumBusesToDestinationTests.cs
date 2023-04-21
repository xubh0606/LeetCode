using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _815_NumBusesToDestinationTests
    {
        [TestMethod()]
        public void NumBusesToDestinationTest()
        {
            int[][] routes = ChangeStringToList.GetArrOfArrForInt("[[1, 2, 7],[3, 6, 7]]");
            int source = 1, target = 6;
            _815_NumBusesToDestination solution = new _815_NumBusesToDestination();
            Assert.AreEqual(2, solution.NumBusesToDestination(routes, source, target));
        }
    }
}