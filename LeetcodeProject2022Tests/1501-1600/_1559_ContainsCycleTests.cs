using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1501_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1501_1600.Tests
{
    [TestClass()]
    public class _1559_ContainsCycleTests
    {
        [TestMethod()]
        public void ContainsCycleTest()
        {
            char[][] grid = ChangeStringToCharArr.GetCharArr("[[ a ,  a ,  a ,  a ],[ a ,  b ,  b ,  a ],[ a ,  b ,  b ,  a ],[ a ,  a ,  a ,  a ]]");
            _1559_ContainsCycle solution = new _1559_ContainsCycle();
            Assert.IsTrue(solution.ContainsCycle(grid));
        }
    }
}