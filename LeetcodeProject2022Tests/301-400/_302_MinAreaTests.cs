using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _302_MinAreaTests
    {
        [TestMethod()]
        public void MinAreaTest()
        {
            char[][] image = ChangeStringToCharArr.GetCharArr("[[ 0 ,  0 ,  1 ,  0 ],[ 0 , 1 , 1 , 0 ],[ 0 , 1 , 0 , 0 ]]");
            int x = 0, y = 2;
            _302_MinArea solution = new _302_MinArea();
            Assert.AreEqual(6, solution.MinArea(image, x, y));
        }
    }
}