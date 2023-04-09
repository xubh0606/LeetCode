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
    public class _354_MaxEnvelopesTests
    {
        [TestMethod()]
        public void MaxEnvelopesTest()
        {
            int[][] envelopes = ChangeStringToList.GetArrOfArrForInt("[[5, 4],[6,4],[6,7],[2,3]]");
            _354_MaxEnvelopes solution = new _354_MaxEnvelopes();
            Assert.AreEqual(3, solution.MaxEnvelopes(envelopes));
        }
    }
}