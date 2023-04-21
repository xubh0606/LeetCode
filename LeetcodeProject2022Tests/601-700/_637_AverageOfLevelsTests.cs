using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _637_AverageOfLevelsTests
    {
        [TestMethod()]
        public void AverageOfLevelsTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _637_AverageOfLevels solution = new _637_AverageOfLevels();
            //输出：[3.00000,14.50000,11.00000]
            Assert.AreEqual(3, solution.AverageOfLevels(root).Count);
        }
    }
}