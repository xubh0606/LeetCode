using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._101_200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._101_200.Tests
{
    [TestClass()]
    public class _141_HasCycleTests
    {
        [TestMethod()]
        public void HasCycleTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 3, 2, 0, -4 });
            _141_HasCycle solution = new _141_HasCycle();
            head.next.next.next.next = head.next;
            Assert.IsTrue(solution.HasCycle(head));
        }
    }
}