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
    public class OFF054_ConvertBSTTests
    {
        [TestMethod()]
        public void ConvertBSTTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 0, -1, 1 });
            OFF054_ConvertBST solution = new OFF054_ConvertBST();
            Assert.AreEqual(1, solution.ConvertBST(root).val);
        }
    }
}