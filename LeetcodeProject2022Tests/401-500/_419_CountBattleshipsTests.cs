using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._401_500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500.Tests
{
    [TestClass()]
    public class _419_CountBattleshipsTests
    {
        [TestMethod()]
        public void CountBattleshipsTest()
        {
            char[][] board = ChangeStringToCharArr.GetCharArr("[[ X ,  . ,  . ,  X ],[ . ,  . ,  . ,  X ],[ . ,  . ,  . ,  X ]]");
            _419_CountBattleships solution = new _419_CountBattleships();
            Assert.AreEqual(2, solution.CountBattleships(board));
        }
    }
}