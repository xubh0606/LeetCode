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
    public class _159_LengthOfLongestSubstringTwoDistinctTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTwoDistinctTest()
        {
            string s = "eceba";
            _159_LengthOfLongestSubstringTwoDistinct solution = new _159_LengthOfLongestSubstringTwoDistinct();
            Assert.AreEqual(3, solution.LengthOfLongestSubstringTwoDistinct(s));
        }
    }
}