using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _354_MaxEnvelopes
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            //先建立行为高度，列为宽度的列表，然后分别排序。按大小顺序分别查找最大存储数量，然后返回最大值
            IList<IList<int>> envelopesList = new List<IList<int>>();
            int count = 0;
            int maxWight = 0;
            int[] place = new int[100001];
            IList<int> listW = new List<int>();
            for (int i = 0; i < envelopes.Length; i++)
            {
                int w = envelopes[i][0];
                int h = envelopes[i][1];
                if (w > maxWight)
                {
                    maxWight = w;
                }
                if (place[w] == 0)
                {
                    listW.Add(w);
                    envelopesList.Add(new List<int>());
                    envelopesList[count].Add(h);
                    place[w] = count + 1;
                    count++;
                }
                else
                {
                    envelopesList[place[w] - 1].Add(h);
                }
            }
            IList<int[]> envelopesArr = new List<int[]>();
            for (int i = 0; i < envelopesList.Count; i++)
            {
                int[] a = envelopesList[i].ToArray();
                Array.Sort(a);
                envelopesArr.Add(a);
            }
            int max_env = 0;
            int[] arr2 = listW.ToArray();
            Array.Sort(arr2);
            int j;
            int[] arr1 = new int[arr2.Length];
            arr1[0] = envelopesArr[place[arr2[0]] - 1][0];
            for (int i = 1; i < arr2.Length; i++)
            {
                int[] arrH = envelopesArr[place[arr2[i]] - 1];
                for (j = max_env; j >= 0; j--)
                {
                    int min_H = GetMinH(arr1[j], arrH);
                    if (min_H > 0 && (arr1[j + 1] == 0 || arr1[j + 1] > min_H))
                    {
                        arr1[j + 1] = min_H;
                        if (j == max_env)
                        {
                            max_env++;
                        }
                    }
                    if (arr1[j] < arrH[0])
                    {
                        break;
                    }
                }
                if (arrH[0] < arr1[0])
                {
                    arr1[0] = arrH[0];
                }
            }
            return max_env + 1;
        }
        int GetMinH(int w, int[] arrH)
        {
            int right = arrH.Length - 1;
            if (w >= arrH[right])
            {
                return -1;
            }
            int left = 0;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (w < arrH[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return arrH[left];
        }
    }
}
