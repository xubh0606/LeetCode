using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _854_KSimilarityTests
    {
        [TestMethod()]
        public void KSimilarityTest()
        {
            string s1 = "ab", s2 = "ba";
            _854_KSimilarity solution = new _854_KSimilarity();
            Assert.AreEqual(1, solution.KSimilarity(s1, s2));
        }
    }
}