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
    public class _1244_LeaderboardTests
    {
        [TestMethod()]
        public void _1244_LeaderboardTest()
        {
            _1244_Leaderboard leaderboard = new _1244_Leaderboard();
            leaderboard.AddScore(1, 73);   // leaderboard = [[1,73]];
            leaderboard.AddScore(2, 56);   // leaderboard = [[1,73],[2,56]];
            leaderboard.AddScore(3, 39);   // leaderboard = [[1,73],[2,56],[3,39]];
            leaderboard.AddScore(4, 51);   // leaderboard = [[1,73],[2,56],[3,39],[4,51]];
            leaderboard.AddScore(5, 4);    // leaderboard = [[1,73],[2,56],[3,39],[4,51],[5,4]];
            leaderboard.Top(1);           // returns 73;
            leaderboard.Reset(1);         // leaderboard = [[2,56],[3,39],[4,51],[5,4]];
            leaderboard.Reset(2);         // leaderboard = [[3,39],[4,51],[5,4]];
            leaderboard.AddScore(2, 51);   // leaderboard = [[2,51],[3,39],[4,51],[5,4]];
            Assert.AreEqual(141, leaderboard.Top(3));           // returns 141 = 51 + 51 + 39;
        }
    }
}