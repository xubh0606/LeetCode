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
    public class _384_ArrayShuffleTests
    {
        [TestMethod()]
        public void _384_ArrayShuffleTest()
        {
            _384_ArrayShuffle solution = new _384_ArrayShuffle(new int[] { 1, 2, 3 });
            solution.Shuffle();    // Shuffle the array [1,2,3] and return its result.
                                   // Any permutation of [1,2,3] must be equally likely to be returned.
                                   // Example: return [3, 1, 2]
            solution.Reset();      // Resets the array back to its original configuration [1,2,3]. Return [1, 2, 3]
            solution.Shuffle();    // Returns the random shuffling of array [1,2,3]. Example: return [1, 3, 2]
        }
    }
}