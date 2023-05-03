using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetcodeProject2022._801_900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900.Tests
{
    [TestClass()]
    public class _895_FreqStackTests
    {
        [TestMethod()]
        public void _895_FreqStackTest()
        {
            _895_FreqStack freqStack = new _895_FreqStack();
            freqStack.Push(5);//堆栈为 [5]
            freqStack.Push(7);//堆栈是 [5,7]
            freqStack.Push(5);//堆栈是 [5,7,5]
            freqStack.Push(7);//堆栈是 [5,7,5,7]
            freqStack.Push(4);//堆栈是 [5,7,5,7,4]
            freqStack.Push(5);//堆栈是 [5,7,5,7,4,5]
            freqStack.Pop();//返回 5 ，因为 5 出现频率最高。堆栈变成 [5,7,5,7,4]。
            freqStack.Pop();//返回 7 ，因为 5 和 7 出现频率最高，但7最接近顶部。堆栈变成 [5,7,5,4]。
            freqStack.Pop();//返回 5 ，因为 5 出现频率最高。堆栈变成 [5,7,4]。
            freqStack.Pop();//返回 4 ，因为 4, 5 和 7 出现频率最高，但 4 是最接近顶部的。堆栈变成 [5,7]。
        }

        [TestMethod()]
        public void _895_FreqStackTest2()
        {
            _895_FreqStack freqStack = new _895_FreqStack();
            freqStack.Push(4);//堆栈为 [4]
            freqStack.Push(0);//堆栈是 [4,0]
            freqStack.Push(9);//堆栈是
            freqStack.Push(3);//堆栈是 
            freqStack.Push(4);//堆栈是 
            freqStack.Push(2);
            freqStack.Pop();//返回
            freqStack.Push(6);
            freqStack.Pop();//返回
            freqStack.Push(1);
            freqStack.Pop();//返回
            freqStack.Push(1);
            freqStack.Pop();//返回
            freqStack.Push(4);
            freqStack.Pop();//返回 
            freqStack.Pop();//返回 
            freqStack.Pop();//返回 
            freqStack.Pop();//返回 
            freqStack.Pop();//返回 
            freqStack.Pop();//返回 
        }
    }
}