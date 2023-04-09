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
    public class _272_ClosestKValuesTests
    {
        [TestMethod()]
        public void ClosestKValuesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 4, 2, 5, 1, 3 });
            double target = 3.714286;
            int k = 2;
            _272_ClosestKValues solution = new _272_ClosestKValues();
            Assert.AreEqual(2, solution.ClosestKValues(root, target, k).Count);
        }
    }
}