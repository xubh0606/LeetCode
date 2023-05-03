using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _530_GetMinimumDifferenceTests
    {
        [TestMethod()]
        public void GetMinimumDifferenceTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 4, 2, 6, 1, 3 });
            _530_GetMinimumDifference solution = new _530_GetMinimumDifference();
            Assert.AreEqual(1, solution.GetMinimumDifference(root));
        }
    }
}