using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1401_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500.Tests
{
    [TestClass()]
    public class _1408_StringMatchingTests
    {
        [TestMethod()]
        public void StringMatchingTest()
        {
            string[] words = new string[] { "mass", "as", "hero", "superhero" };
            _1408_StringMatching solution = new _1408_StringMatching();
            Assert.AreEqual(2, solution.StringMatching(words));
        }
    }
}