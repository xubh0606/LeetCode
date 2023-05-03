using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _92_ReverseBetweenTests
    {
        [TestMethod()]
        public void ReverseBetweenTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 3, 4, 5 });
            int left = 2, right = 4;
            _92_ReverseBetween solution = new _92_ReverseBetween();
            Assert.AreEqual(1, solution.ReverseBetween(head, left, right).val);
        }
    }
}