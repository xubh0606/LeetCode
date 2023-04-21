using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _270_ClosestValueTests
    {
        [TestMethod()]
        public void ClosestValueTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 4, 2, 5, 1, 3 });
            double target = 3.714286;
            _270_ClosestValue solution = new _270_ClosestValue();
            Assert.AreEqual(4, solution.ClosestValue(root, target));
        }
    }
}