using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1469_GetLonelyNodesTests
    {
        [TestMethod()]
        public void GetLonelyNodesTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, -1, 4 });
            _1469_GetLonelyNodes solution = new _1469_GetLonelyNodes();
            Assert.AreEqual(4, solution.GetLonelyNodes(root)[0]);
        }
    }
}