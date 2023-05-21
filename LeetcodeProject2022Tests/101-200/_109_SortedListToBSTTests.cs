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
    public class _109_SortedListToBSTTests
    {
        [TestMethod()]
        public void SortedListToBSTTest()
        {
            ListNode head = new ListNode(-10);
            ListNode child1 = new ListNode(-3);
            ListNode child2 = new ListNode(0);
            ListNode child3 = new ListNode(5);
            ListNode child4 = new ListNode(9);
            head.next = child1;
            child1.next = child2;
            child2.next = child3;
            child3.next = child4;
            _109_SortedListToBST solution = new _109_SortedListToBST();
            Assert.AreEqual(0, solution.SortedListToBST(head).val);
        }
    }
}