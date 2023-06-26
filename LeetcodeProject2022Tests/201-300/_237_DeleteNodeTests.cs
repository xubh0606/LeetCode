using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _237_DeleteNodeTests
    {
        [TestMethod()]
        public void DeleteNodeTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 4, 5, 1, 9 });
            ListNode node = head.next;
            _237_DeleteNode solution = new _237_DeleteNode();
            solution.DeleteNode(node);
            Assert.AreEqual(1, head.next.val);
        }
    }
}