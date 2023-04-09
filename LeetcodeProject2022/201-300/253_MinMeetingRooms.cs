using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _253_MinMeetingRooms
    {
        LinkedList<int> m_listOfEnd;
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            m_listOfEnd = new LinkedList<int>();
            m_listOfEnd.AddFirst(intervals[0][1]);
            for (int i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] < m_listOfEnd.First.Value)
                {
                    //如果没有能够插入的位置，则创造新位置
                    if(intervals[i][1] < m_listOfEnd.First.Value)
                    {
                        m_listOfEnd.AddFirst(intervals[i][1]);
                    }
                    else
                    {
                        m_listOfEnd.AddAfter(FindFirstSmaller(intervals[i][1]), intervals[i][1]);
                    }
                }
                else
                {
                    //存在旧有位置，则遵循贪心原则，延续最靠后的那个
                    m_listOfEnd.AddAfter(FindFirstSmaller(intervals[i][1]), intervals[i][1]);
                    m_listOfEnd.Remove(FindFirstSmaller(intervals[i][0]));
                }
            }
            return m_listOfEnd.Count;
        }
        //找到第一个小于需要插入数字的位置
        LinkedListNode<int> FindFirstSmaller(int value)
        {
            LinkedListNode<int> node = m_listOfEnd.Last;
            while(node.Value > value)
            {
                node = node.Previous;
            }
            return node;
        }
    }
}
