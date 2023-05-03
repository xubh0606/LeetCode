using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1201_1300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300.Tests
{
    [TestClass()]
    public class _1202_SmallestStringWithSwapsTests
    {
        [TestMethod()]
        public void SmallestStringWithSwapsTest()
        {
            string s = "cba";
            IList<IList<int>> pairs = ChangeStringToList.GetIListIListForInt("[[0, 1],[1, 2]]");
            _1202_SmallestStringWithSwaps solution = new _1202_SmallestStringWithSwaps();
            Assert.AreEqual("abc", solution.SmallestStringWithSwaps(s, pairs));
        }

        [TestMethod()]
        public void SmallestStringWithSwapsTest2()
        {
            string s = "cegfxvulsxakw";
            IList<IList<int>> pairs = ChangeStringToList.GetIListIListForInt("[[6, 6],[5, 7],[11, 4],[0, 0],[6, 2],[6, 7],[0, 7],[4, 0],[3, 1],[2, 9],[4, 7],[8, 6],[9, 0]]");
            _1202_SmallestStringWithSwaps solution = new _1202_SmallestStringWithSwaps();
            Assert.AreEqual("cegfklsuvxaxw", solution.SmallestStringWithSwaps(s, pairs));
        }

        [TestMethod()]
        public void SmallestStringWithSwapsTest3()
        {
            string s = "icjkcvebjmuzokbvgusbfgz";
            IList<IList<int>> pairs = ChangeStringToList.GetIListIListForInt("[[14,19],[19,8],[22,2],[0,7],[20,22],[11,21],[0,2],[21,9],[18,11],[14,17],[2,11],[19,8],[1,0],[4,16],[15,19],[15,9],[0,14],[9,16],[9,14],[8,15],[7,6],[11,21],[5,15]]");
            _1202_SmallestStringWithSwaps solution = new _1202_SmallestStringWithSwaps();
            Assert.AreEqual(s.Length, solution.SmallestStringWithSwaps(s, pairs).Length);
        }
    }
}