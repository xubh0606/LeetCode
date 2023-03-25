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
    public class _187_FindRepeatedDnaSequencesTests
    {
        [TestMethod()]
        public void FindRepeatedDnaSequencesTest()
        {
            string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            _187_FindRepeatedDnaSequences solution = new _187_FindRepeatedDnaSequences();
            Assert.AreEqual(2, solution.FindRepeatedDnaSequences(s).Count);
        }
    }
}