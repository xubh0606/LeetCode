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
    public class _311_MultiplyTests
    {
        [TestMethod()]
        public void MultiplyTest()
        {
            _311_Multiply solution = new _311_Multiply();
            int[][] mat1 = ChangeStringToList.GetArrOfArrForInt("[[1, 0, 0],[-1,0,3]]"), mat2 = ChangeStringToList.GetArrOfArrForInt("[[7, 0, 0],[0,0,0],[0,0,1]]");
            int[][] res = solution.Multiply(mat1, mat2);
            int[][] target = ChangeStringToList.GetArrOfArrForInt("[[7,0,0],[-7,0,3]]");
            for(int i = 0; i < res.Length; i++)
            {
                for(int j = 0; j < res.Length; j++)
                {
                    Assert.AreEqual(target[i][j], res[i][j]);
                }
            }
        }
    }
}