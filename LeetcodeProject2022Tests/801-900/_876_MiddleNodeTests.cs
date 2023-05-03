using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _876_MiddleNodeTests
    {
        [TestMethod()]
        public void MiddleNodeTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 3, 4, 5 });
            _876_MiddleNode solution = new _876_MiddleNode();
            Assert.AreEqual(3, solution.MiddleNode(head).val);
        }
    }
}