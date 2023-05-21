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
    public class _82_DeleteDuplicatesTests
    {
        [TestMethod()]
        public void DeleteDuplicatesTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 3, 3, 4, 4, 5 });
            _82_DeleteDuplicates solution = new _82_DeleteDuplicates();
            //输出：[1,2,5]
            Assert.AreEqual(1, solution.DeleteDuplicates(head).val);
        }
    }
}