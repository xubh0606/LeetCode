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
    public class _83_DeleteDuplicatesTests
    {
        [TestMethod()]
        public void DeleteDuplicatesTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 1, 2 });
            _83_DeleteDuplicates solution = new _83_DeleteDuplicates();
            Assert.AreEqual(1, solution.DeleteDuplicates(head).val);
        }
    }
}