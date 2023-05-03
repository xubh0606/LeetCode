using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class _1730_GetFoodTests
    {
        [TestMethod()]
        public void GetFoodTest()
        {
            char[][] grid = ChangeStringToCharArr.GetCharArr("[[ X ,  X ,  X ,  X ,  X ,  X ],[ X ,  * ,  O ,  O ,  O ,  X ],[ X ,  O ,  O ,  # ,  O ,  X ],[ X ,  X ,  X ,  X ,  X ,  X ]]");
            _1730_GetFood solution = new _1730_GetFood();
            Assert.AreEqual(3, solution.GetFood(grid));
        }
    }
}