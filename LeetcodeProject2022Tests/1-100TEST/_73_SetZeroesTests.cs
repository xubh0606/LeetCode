using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._1_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100.Tests
{
    [TestClass()]
    public class _73_SetZeroesTests
    {
        [TestMethod()]
        public void SetZeroesTest()
        {
            string s = "[[1, 1, 1],[1, 0, 1],[1, 1, 1]]";
            string sRes = "[[1,0,1],[0,0,0],[1,0,1]]";
            _73_SetZeroes solution = new _73_SetZeroes();
            int[][] arr1 = ChangeStringToList.GetArrOfArrForInt(s);
            solution.SetZeroes(arr1);
            int[][] arr2 = ChangeStringToList.GetArrOfArrForInt(sRes);
            Assert.IsTrue(CompareToAnother.IsSameArrArrInt(arr1, arr2));
        }
    }
}