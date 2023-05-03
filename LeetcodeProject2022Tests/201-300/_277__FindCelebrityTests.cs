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
    public class _277__FindCelebrityTests
    {
        [TestMethod()]
        public void FindCelebrityTest()
        {
            int[][] party = ChangeStringToList.GetArrOfArrForInt("[[1, 1, 0], [0, 1, 0],[1, 1, 1]]");
            _277__FindCelebrity findCelebrity = new _277__FindCelebrity(party);
            Assert.AreEqual(1, findCelebrity.FindCelebrity(party.Length));
        }
    }
}