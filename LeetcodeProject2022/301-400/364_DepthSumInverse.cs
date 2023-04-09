using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _364_DepthSumInverse
    {
        //public int DepthSumInverse(IList<NestedInteger> nestedList)
        //{
        //    int sum = 0;
        //    int maxDeepth = 1;
        //    int count = nestedList.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        NestedInteger temp = nestedList[i];
        //        if (!temp.IsInteger())
        //        {
        //            IList<NestedInteger> list = temp.GetList();
        //            maxDeepth = Math.Max(maxDeepth, GetDeepth(list, 2));
        //        }
        //    }
        //    for (int j = 0; j < count; j++)
        //    {
        //        NestedInteger temp = nestedList[j];
        //        if (temp.IsInteger())
        //        {
        //            sum += maxDeepth * temp.GetInteger();
        //        }
        //        else
        //        {
        //            sum += SumInverse(temp.GetList(), maxDeepth - 1);
        //        }
        //    }
        //    return sum;
        //}
        //int GetDeepth(IList<NestedInteger> list, int curDeep)
        //{
        //    int count = list.Count;
        //    if (count == 0)
        //    {
        //        return curDeep - 1;
        //    }
        //    int maxDeep = curDeep;

        //    for (int i = 0; i < count; i++)
        //    {
        //        NestedInteger temp = list[i];
        //        if (!temp.IsInteger())
        //        {
        //            maxDeep = Math.Max(maxDeep, GetDeepth(temp.GetList(), curDeep + 1));
        //        }
        //    }
        //    return maxDeep;
        //}
        //int SumInverse(IList<NestedInteger> list, int wight)
        //{
        //    int curSum = 0;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        NestedInteger temp = list[i];
        //        if (temp.IsInteger())
        //        {
        //            curSum += wight * temp.GetInteger();
        //        }
        //        else
        //        {
        //            curSum += SumInverse(temp.GetList(), wight - 1);
        //        }
        //    }
        //    return curSum;
        //}
    }
}
