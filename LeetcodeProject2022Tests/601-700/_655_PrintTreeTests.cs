using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._601_700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700.Tests
{
    [TestClass()]
    public class _655_PrintTreeTests
    {
        [TestMethod()]
        public void PrintTreeTest()
        {
            TreeNode root = TreeNode.GetTree(new int[] { 1, 2, 3, -1, 4 });
            //输出：
            //[["","","","1","","",""],
            //["","2","","","","3",""],
            //["","","4","","","",""]]
            _655_PrintTree solution = new _655_PrintTree();
            Assert.AreEqual(3, solution.PrintTree(root).Count);
        }
    }
}