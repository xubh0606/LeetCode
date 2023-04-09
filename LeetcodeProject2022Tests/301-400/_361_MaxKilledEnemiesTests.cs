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
    public class _361_MaxKilledEnemiesTests
    {
        [TestMethod()]
        public void MaxKilledEnemiesTest()
        {
            char[][] grid = ChangeStringToCharArr.GetCharArr("[[ 0 ,  E ,  0 ,  0 ],[ E , 0 , W , E ],[ 0 , E , 0 , 0 ]]");
            _361_MaxKilledEnemies solution = new _361_MaxKilledEnemies();
            Assert.AreEqual(3, solution.MaxKilledEnemies(grid));
        }
    }
}