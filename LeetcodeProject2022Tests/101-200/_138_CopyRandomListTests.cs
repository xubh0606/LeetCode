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
    public class _138_CopyRandomListTests
    {
        [TestMethod()]
        public void CopyRandomListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CopyRandomListTest1()
        {
            //输入：head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
            //输出：[[7,null],[13,0],[11,4],[10,2],[1,0]]
            _138_CopyRandomList solution = new _138_CopyRandomList();
            _138_Node head = new _138_Node(7);
            head.random = null;
            _138_Node c1 = new _138_Node(13);
            c1.random = head;
            _138_Node c4 = new _138_Node(1);
            c4.random = head;
            _138_Node c2 = new _138_Node(11);
            c2.random = c4;
            _138_Node c3 = new _138_Node(10);
            c3.random = c2;
            head.next = c1;
            c1.next = c2;
            c2.next = c3;
            c3.next = c4;
            Assert.AreEqual(7, solution.CopyRandomList(head).val);
        }
    }
}