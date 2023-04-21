using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeProject2022._701_800._708_Insert;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _708_InsertTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            _708_Node head = new _708_Node(3);
            head.next = new _708_Node(4);
            head.next.next = new _708_Node(1);
            head.next.next.next = head;
            _708_Insert solution = new _708_Insert();
            solution.Insert(head, 2);
            //输入：head = [3,4,1], insertVal = 2
            //输出：[3,4,1,2]
            Assert.AreEqual(2, head.next.next.next.val);
        }
    }
}