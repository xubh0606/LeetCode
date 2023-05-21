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
    public class _24_SwapPairsTests
    {
        [TestMethod()]
        public void SwapPairsTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 3, 4 });
            _24_SwapPairs solution = new _24_SwapPairs();
            Assert.AreEqual(2, solution.SwapPairs(head).val);
        }
    }
}