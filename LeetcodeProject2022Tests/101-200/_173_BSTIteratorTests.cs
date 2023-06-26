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
    public class _173_BSTIteratorTests
    {
        [TestMethod()]
        public void _173_BSTIteratorTest()
        {
            _173_BSTIterator bSTIterator = new _173_BSTIterator(TreeNode.GetTree(new int[] { 7, 3, 15, -1, -1, 9, 20 }));
            bSTIterator.Next();    // 返回 3
            bSTIterator.Next();    // 返回 7
            bSTIterator.HasNext(); // 返回 True
            bSTIterator.Next();    // 返回 9
            bSTIterator.HasNext(); // 返回 True
            bSTIterator.Next();    // 返回 15
            bSTIterator.HasNext(); // 返回 True
            bSTIterator.Next();    // 返回 20
            bSTIterator.HasNext(); // 返回 False
        }
    }
}