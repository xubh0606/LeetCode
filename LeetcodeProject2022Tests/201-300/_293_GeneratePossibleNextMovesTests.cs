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
    public class _293_GeneratePossibleNextMovesTests
    {
        [TestMethod()]
        public void GeneratePossibleNextMovesTest()
        {
            string currentState = "++++";
            _293_GeneratePossibleNextMoves solution = new _293_GeneratePossibleNextMoves();
            string[] arr = new string[] { "--++", "+--+", "++--" };
            IList<string> list = solution.GeneratePossibleNextMoves(currentState);
            for(int i = 0; i < 3; i++)
            {
                Assert.AreEqual(arr[i], list[i]);
            }
        }
    }
}