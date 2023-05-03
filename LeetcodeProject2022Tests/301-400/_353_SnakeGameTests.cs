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
    public class _353_SnakeGameTests
    {
        [TestMethod()]
        public void _353_SnakeGameTest()
        {
            _353_SnakeGame snakeGame = new _353_SnakeGame(3, 2, ChangeStringToList.GetArrOfArrForInt("[[1, 2], [0, 1]]"));
            snakeGame.Move("R"); // 返回 0
            snakeGame.Move("D"); // 返回 0
            snakeGame.Move("R"); // 返回 1 ，蛇吃掉了第一个食物，同时第二个食物出现在 (0, 1)
            snakeGame.Move("U"); // 返回 1
            snakeGame.Move("L"); // 返回 2 ，蛇吃掉了第二个食物，没有出现更多食物
            snakeGame.Move("U"); // 返回 -1 ，蛇与边界相撞，游戏结束
        }

        [TestMethod()]
        public void _353_SnakeGameTest_OutRange()
        {
            _353_SnakeGame snakeGame = new _353_SnakeGame(2, 2, ChangeStringToList.GetArrOfArrForInt("[[2, 2], [0, 1]]"));
            snakeGame.Move("R"); // 返回 -1
            snakeGame.Move("D"); // 返回 -1
        }

    }
}