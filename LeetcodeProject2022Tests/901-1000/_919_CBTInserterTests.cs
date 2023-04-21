using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._901_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000.Tests
{
    [TestClass()]
    public class _919_CBTInserterTests
    {
        [TestMethod()]
        public void _919_CBTInserterTest()
        {
            _919_CBTInserter cBTInserter = new _919_CBTInserter(TreeNode.GetTree(new int[] { 1, 2 }));
            cBTInserter.Insert(3);  // 返回 1
            cBTInserter.Insert(4);  // 返回 2
            cBTInserter.Get_root(); // 返回 [1, 2, 3, 4]
        }
    }
}