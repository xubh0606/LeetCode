using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _353_SnakeGame
    {
        int m_width;
        int m_height;
        int[][] m_food;
        int m_foodIndex;
        Queue<Tuple<int, int>> m_body;
        Tuple<int, int> m_head;
        string m_lastStr;
        HashSet<Tuple<int, int>> m_bodySet;
        public _353_SnakeGame(int width, int height, int[][] food)
        {
            m_food = food;
            m_height = height;
            m_width = width;
            m_foodIndex = 0;
            m_body = new Queue<Tuple<int, int>>();
            m_head = new Tuple<int, int>(0, 0);
            m_body.Enqueue(m_head);
            m_lastStr = "";
            m_bodySet = new HashSet<Tuple<int, int>>();
            m_bodySet.Add(m_head);
        }

        public int Move(string direction)
        {
            int row = this.m_head.Item1;
            int col = this.m_head.Item2;
            if (direction == m_lastStr)
            {
                return m_foodIndex;
            }
            if (direction == "R")
            {
                col++;
            }
            if (direction == "L")
            {
                col--;
            }
            if (direction == "U")
            {
                row--;
            }
            if (direction == "D")
            {
                row++;
            }
            if (row < 0 || row == m_height || col < 0 || col == m_width)
            {
                return -1;
            }
            if (m_foodIndex < m_food.Length && m_food[m_foodIndex][0] == row && m_food[m_foodIndex][1] == col)
            {
                m_foodIndex++;
            }
            else
            {
                Tuple<int, int> tail = m_body.Dequeue();
                m_bodySet.Remove(tail);
            }
            m_head = new Tuple<int, int>(row, col);
            if (m_bodySet.Contains(m_head))
            {
                return -1;
            }
            m_body.Enqueue(m_head);
            m_bodySet.Add(m_head);
            m_lastStr = direction;
            return m_foodIndex;
        }
    }

    /**
     * Your SnakeGame object will be instantiated and called as such:
     * SnakeGame obj = new SnakeGame(width, height, food);
     * int param_1 = obj.Move(direction);
     */

}
