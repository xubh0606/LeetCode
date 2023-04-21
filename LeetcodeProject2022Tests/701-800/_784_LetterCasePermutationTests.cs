using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._701_800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800.Tests
{
    [TestClass()]
    public class _784_LetterCasePermutationTests
    {
        [TestMethod()]
        public void LetterCasePermutationTest()
        {
            string s = "a1b2";
            _784_LetterCasePermutation solution = new _784_LetterCasePermutation();
            Assert.AreEqual(4, solution.LetterCasePermutation(s).Count);
        }
    }
}