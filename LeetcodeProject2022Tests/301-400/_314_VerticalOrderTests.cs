using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _314_VerticalOrderTests
    {
        [TestMethod()]
        public void VerticalOrderTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 3, 9, 20, -1, -1, 15, 7 });
            _314_VerticalOrder solution = new _314_VerticalOrder();
            //输出：[[9],[3,15],[20],[7]]
            Assert.IsTrue(solution.VerticalOrder(root).Count == 4);
        }
    }
}