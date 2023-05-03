using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _904_TotalFruitTests
    {
        [TestMethod()]
        public void TotalFruitTest()
        {
            int[] fruits = new int[] { 0, 1, 2, 2 };
            _904_TotalFruit solution = new _904_TotalFruit();
            Assert.AreEqual(3, solution.TotalFruit(fruits));
        }
    }
}