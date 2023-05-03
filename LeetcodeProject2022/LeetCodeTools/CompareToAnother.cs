using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022
{
    //判断是否相同
    public class CompareToAnother
    {
        public static bool IsSameArrInt(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsSameArrArrInt(int[][] arr1, int[][] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!IsSameArrInt(arr1[i], arr2[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsSameList(IList<int> list1, IList<int> list2)
        {
            if(list1.Count != list2.Count)
            {
                return false;
            }
            for(int i = 0; i < list2.Count; i++)
            {
                if(list2[i] != list1[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsSameListList(IList<IList<int>> list1, IList<IList<int>> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }
            for (int i = 0; i < list2.Count; i++)
            {
                if (!IsSameList(list1[i], list2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
