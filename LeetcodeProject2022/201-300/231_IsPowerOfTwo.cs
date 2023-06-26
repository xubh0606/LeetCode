﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _231_IsPowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            return (n & (n - 1)) == 0;
        }
    }
}
