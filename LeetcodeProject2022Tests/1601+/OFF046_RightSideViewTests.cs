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
    public class OFF046_RightSideViewTests
    {
        [TestMethod()]
        public void RightSideViewTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, -1, 5, -1, 4 });
            OFF046_RightSideView solution = new OFF046_RightSideView();
            Assert.AreEqual(3, solution.RightSideView(root).Count);
        }
    }
}