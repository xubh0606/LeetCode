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
    public class _147_InsertionSortListTests
    {
        [TestMethod()]
        public void InsertionSortListTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 4, 2, 1, 3 });
            _147_InsertionSortList solution = new _147_InsertionSortList();
            Assert.AreEqual(1, solution.InsertionSortList(head));
        }
    }
}