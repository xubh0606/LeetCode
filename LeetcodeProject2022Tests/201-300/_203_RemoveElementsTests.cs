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
    public class _203_RemoveElementsTests
    {
        [TestMethod()]
        public void RemoveElementsTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            int val = 6;
            _203_RemoveElements solution = new _203_RemoveElements();
            Assert.AreEqual(1, solution.RemoveElements(head, val).val);
        }
    }
}