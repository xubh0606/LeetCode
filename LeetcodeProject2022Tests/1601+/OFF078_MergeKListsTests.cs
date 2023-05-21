using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1601_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_.Tests
{
    [TestClass()]
    public class OFF078_MergeKListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            ListNode[] lists = new ListNode[3];
            lists[0] = ListNode.GetListNode(new int[] { 1, 4, 5 });
            lists[1] = ListNode.GetListNode(new int[] { 1, 3, 4 });
            lists[2] = ListNode.GetListNode(new int[] { 2, 6 });
            OFF078_MergeKLists solution = new OFF078_MergeKLists();
            Assert.AreEqual(1, solution.MergeKLists(lists).val);
        }
    }
}