using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1101_1200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200.Tests
{
    [TestClass()]
    public class _1171_RemoveZeroSumSublistsTests
    {
        [TestMethod()]
        public void RemoveZeroSumSublistsTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 3, -3, 4 });
            _1171_RemoveZeroSumSublists solution = new _1171_RemoveZeroSumSublists();
            Assert.AreEqual(1, solution.RemoveZeroSumSublists(head).val);
        }
    }
}