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
    public class _386_LexicalOrderTests
    {
        [TestMethod()]
        public void LexicalOrderTest()
        {
            int[] arr = new int[]{ 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 };
            _386_LexicalOrder solution = new _386_LexicalOrder();
            IList<int> target = solution.LexicalOrder(13);
            for(int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(target[i], arr[i]);
            }
        }
    }
}