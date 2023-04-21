using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._201_300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300.Tests
{
    [TestClass()]
    public class _251_Vector2DTests
    {
        [TestMethod()]
        public void _251_Vector2DTest()
        {
            _251_Vector2D iterator = new _251_Vector2D(ChangeStringToList.GetArrOfArrForInt("[[1, 2],[3],[4]]"));

            iterator.Next(); // 返回 1
            iterator.Next(); // 返回 2
            iterator.Next(); // 返回 3
            iterator.HasNext(); // 返回 true
            iterator.HasNext(); // 返回 true
            iterator.Next(); // 返回 4
            iterator.HasNext(); // 返回 false
        }
    }
}