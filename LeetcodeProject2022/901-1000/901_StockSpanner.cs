using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _901_StockSpanner
    {
        IList<int> m_StockPrice;
        IList<int> m_Spanners;
        public _901_StockSpanner()
        {
            m_Spanners = new List<int>();
            m_StockPrice = new List<int>();
        }

        public int Next(int price)
        {
            int index = m_Spanners.Count - 1;
            while (index >= 0 && m_StockPrice[index] <= price)
            {
                index -= m_Spanners[index];
            }
            m_Spanners.Add(m_Spanners.Count - index);
            m_StockPrice.Add(price);
            return m_Spanners[m_Spanners.Count - 1];
        }
    }
}
