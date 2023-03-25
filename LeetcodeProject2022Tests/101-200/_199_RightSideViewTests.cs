using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _199_RightSideViewTests
    {
        [TestMethod()]
        public void RightSideViewTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, -1, 5, -1, 4 });
            _199_RightSideView solution = new _199_RightSideView();
            IList<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(3);
            list1.Add(4);
            Assert.IsTrue(CompareToAnother.IsSameList(list1, solution.RightSideView(root)));
        }
    }
}