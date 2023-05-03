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
    public class _86_PartitionTests
    {
        [TestMethod()]
        public void PartitionTest()
        {
            ListNode head = ListNode.GetListNode(new int[]{ 1,4,3,2,5,2});
            int n = 3;
            _86_Partition solution = new _86_Partition();
            Assert.AreEqual(1, solution.Partition(head, n).val);
        }
    }
}