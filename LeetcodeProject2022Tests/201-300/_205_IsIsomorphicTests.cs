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
    public class _205_IsIsomorphicTests
    {
        [TestMethod()]
        public void IsIsomorphicTest()
        {
            string s = "egg", t = "add";
            _205_IsIsomorphic solution = new _205_IsIsomorphic();
            Assert.IsTrue(solution.IsIsomorphic(s, t));
        }
    }
}