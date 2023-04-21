using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _241_DiffWaysToCompute
    {
        IList<IList<IList<int>>> m_listRes;
        IList<bool[]> m_hasList;
        public IList<int> DiffWaysToCompute(string expression)
        {
            IList<int> nums = new List<int>();
            IList<int> operators = new List<int>();
            int count = 0;
            int num = 0;
            while (count < expression.Length)
            {
                if (expression[count] == '-')
                {
                    nums.Add(num);
                    num = 0;
                    operators.Add(-1);
                    count++;
                }
                else if (expression[count] == '+')
                {
                    nums.Add(num);
                    num = 0;
                    operators.Add(1);
                    count++;
                }
                else if (expression[count] == '*')
                {
                    nums.Add(num);
                    num = 0;
                    operators.Add(0);
                    count++;
                }
                else
                {
                    num = num * 10 + expression[count] - '0';
                    count++;
                }
            }
            nums.Add(num);
            m_listRes = new List<IList<IList<int>>>();
            m_hasList = new List<bool[]>();
            for (int i = 0; i < nums.Count; i++)
            {
                m_hasList.Add(new bool[nums.Count]);
                m_listRes.Add(new List<IList<int>>());
                for (int j = i; j < nums.Count; j++)
                {
                    m_listRes[i].Add(new List<int>());
                }
            }
            m_hasList[0][0] = true;
            m_listRes[0][0].Add(nums[0]);
            for (int i = 1; i < operators.Count + 1; i++)
            {
                getList(nums, operators, 0, i);
            }
            return m_listRes[0][nums.Count - 1];
        }
        IList<int> getList(IList<int> nums, IList<int> operators, int start, int end)
        {
            if (m_hasList[start][end - start])
            {
                return m_listRes[start][end - start];
            }
            if (start == end)
            {
                m_hasList[start][end - start] = true;
                m_listRes[start][end - start].Add(nums[end]);
                return m_listRes[start][end - start];
            }
            for (int i = start; i < end; i++)
            {
                IList<int> list1 = getList(nums, operators, start, i);
                IList<int> list2 = getList(nums, operators, i + 1, end);
                if (operators[i] == 0)
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        for (int k = 0; k < list2.Count; k++)
                        {
                            m_listRes[start][end - start].Add(list1[j] * list2[k]);
                        }
                    }
                }
                if (operators[i] == -1)
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        for (int k = 0; k < list2.Count; k++)
                        {
                            m_listRes[start][end - start].Add(list1[j] - list2[k]);
                        }
                    }
                }
                if (operators[i] == 1)
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        for (int k = 0; k < list2.Count; k++)
                        {
                            m_listRes[start][end - start].Add(list1[j] + list2[k]);
                        }
                    }
                }
            }
            m_hasList[start][end - start] = true;
            return m_listRes[start][end - start];
        }
    }
}
