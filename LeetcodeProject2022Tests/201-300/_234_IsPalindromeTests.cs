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
    public class _234_IsPalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            ListNode head = ListNode.GetListNode(new int[] { 1, 2, 2, 1 });
            _234_IsPalindrome solution = new _234_IsPalindrome();
            Assert.IsTrue(solution.IsPalindrome(head));
        }
    }
}