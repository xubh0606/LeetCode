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
    public class _348_TicTacToeTests
    {
        [TestMethod()]
        public void _348_TicTacToeTest()
        {
            _348_TicTacToe toe = new _348_TicTacToe(3);
            toe.Move(0, 0, 1); //函数返回 0(此时，暂时没有玩家赢得这场对决)
            toe.Move(0, 2, 2); // 函数返回 0(暂时没有玩家赢得本场比赛)
            toe.Move(2, 2, 1); //函数返回 0(暂时没有玩家赢得比赛)
            toe.Move(1, 1, 2); // 函数返回 0(暂没有玩家赢得比赛)
            toe.Move(2, 0, 1); // 函数返回 0(暂无玩家赢得比赛)  
            toe.Move(1, 0, 2); // 函数返回 0(没有玩家赢得比赛)
            toe.Move(2, 1, 1); // 函数返回 1(此时，玩家 1 赢得了该场比赛)
        }
    }
}