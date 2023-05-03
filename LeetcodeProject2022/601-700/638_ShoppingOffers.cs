using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _638_ShoppingOffers
    {
        int m_minCost;
        int m_n;
        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            m_minCost = int.MaxValue;
            m_n = price.Count;
            TrackBack(price, special, needs, 0, 0);
            return m_minCost;
        }
        void TrackBack(IList<int> price, IList<IList<int>> special, IList<int> needs, int start, int cost)
        {
            //第一步，确定当前大礼包使用情况下全填充基础价格后的总价，并且输入到min判断中。记忆化加速dic
            int c = cost;
            for (int i = 0; i < m_n; i++)
            {
                c += needs[i] * price[i];
            }
            m_minCost = Math.Min(c, m_minCost);
            for (int i = start; i < special.Count; i++)
            {
                IList<int> new_needs = new List<int>(needs);
                bool b = true;
                for (int j = 0; j < m_n; j++)
                {
                    new_needs[j] -= special[i][j];
                    if (new_needs[j] < 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    TrackBack(price, special, new_needs, i, cost + special[i][m_n]);
                }
            }
        }
    }
}
