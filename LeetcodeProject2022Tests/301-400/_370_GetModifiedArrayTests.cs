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
    public class _370_GetModifiedArrayTests
    {
        [TestMethod()]
        public void GetModifiedArrayTest()
        {
            int length = 5;
            int[][] updates = ChangeStringToList.GetArrOfArrForInt("[[1, 3, 2],[2,4,3],[0,2,-2]]");
            _370_GetModifiedArray solution = new _370_GetModifiedArray();
            //输出: [-2,0,3,5,3]
            int[] target = new int[] { -2, 0, 3, 5, 3 };
            for(int i = 0; i < length; i++)
            {
                Assert.AreEqual(target[i], solution.GetModifiedArray(length, updates));
            }
        }
    }
}