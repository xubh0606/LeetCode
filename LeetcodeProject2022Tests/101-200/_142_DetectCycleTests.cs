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
    public class _142_DetectCycleTests
    {
        [TestMethod()]
        public void DetectCycleTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 3, 2, 0, -4 });
            _142_DetectCycle solution = new _142_DetectCycle();
            head.next.next.next.next = head.next;
            Assert.AreEqual(2, solution.DetectCycle(head).val);
        }
    }
}