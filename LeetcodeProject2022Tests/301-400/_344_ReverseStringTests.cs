using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._301_400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400.Tests
{
    [TestClass()]
    public class _344_ReverseStringTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            char[] target = new char[] { 'o', 'l', 'l', 'e', 'h' };
            _344_ReverseString solution = new _344_ReverseString();
            solution.ReverseString(s);
            Assert.AreEqual(s.Length, target.Length);
            for(int i = 0; i < s.Length; i++)
            {
                Assert.AreEqual(s[0], target[0]);
            }
        }
    }
}