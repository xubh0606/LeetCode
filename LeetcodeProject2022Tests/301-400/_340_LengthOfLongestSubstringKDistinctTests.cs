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
    public class _340_LengthOfLongestSubstringKDistinctTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringKDistinctTest()
        {
            string s = "eceba";
            int k = 2;
            _340_LengthOfLongestSubstringKDistinct solution = new _340_LengthOfLongestSubstringKDistinct();
            Assert.AreEqual(3, solution.LengthOfLongestSubstringKDistinct(s, k));
        }
    }
}