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
    public class _864_ShortestPathAllKeysTests
    {
        [TestMethod()]
        public void ShortestPathAllKeysTest()
        {
            string[] grid = new string[] { "@.a.#", "###.#", "b.A.B" };
            _864_ShortestPathAllKeys solution = new _864_ShortestPathAllKeys();
            Assert.AreEqual(8, solution.ShortestPathAllKeys(grid));
        }
    }
}