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
    public class LCP_34_MaxValueTests
    {
        [TestMethod()]
        public void MaxValueTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 4, 1, 3, 9, -1, -1, 2 });
            int k = 2;
            LCP_34_MaxValue solution = new LCP_34_MaxValue();
            Assert.AreEqual(16, solution.MaxValue(root, k));
        }
    }
}