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
    public class _242_IsAnagramTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            string s = "anagram", t = "nagaram";
            _242_IsAnagram solution = new _242_IsAnagram();
            Assert.IsTrue(solution.IsAnagram(s, t));
        }
    }
}