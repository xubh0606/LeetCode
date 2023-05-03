using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._501_600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600.Tests
{
    [TestClass()]
    public class _513_FindBottomLeftValueTests
    {
        [TestMethod()]
        public void FindBottomLeftValueTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 2, 1, 3 });
            _513_FindBottomLeftValue solution = new _513_FindBottomLeftValue();
            Assert.AreEqual(1, solution.FindBottomLeftValue(root));
        }
    }
}