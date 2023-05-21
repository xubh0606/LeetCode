using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF033_VerifyPostorder
    {
        public bool VerifyPostorder(int[] postorder)
        {
            if (postorder.Length < 2)
            {
                return true;
            }
            //转换为已知尾部为根节点判断二叉搜索树问题
            return Cheak(postorder, 0, postorder.Length - 1, int.MinValue, int.MaxValue);
        }
        bool Cheak(int[] postorder, int left, int right, int min, int max)
        {
            if (left > right)
            {
                return true;
            }
            if (left == right)
            {
                return postorder[left] > min && postorder[right] < max;
            }
            //获得中心节点
            int midNum = postorder[right];
            if (midNum < min || midNum > max)
            {
                return false;
            }
            if (postorder[left] > midNum)
            {
                return Cheak(postorder, left, right - 1, midNum, max);
            }
            //二分获取一个左侧小右侧大的位置
            int mid = FindMid(postorder, midNum, left, right - 1);
            if (postorder[mid] > postorder[mid + 1])
            {
                return false;
            }
            return Cheak(postorder, left, mid, min, midNum) &&
            Cheak(postorder, mid + 1, right - 1, midNum, max);
        }
        public int FindMid(int[] postorder, int midNum, int left, int right)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (postorder[mid] > midNum)
                {
                    right = mid - 1;
                }
                else
                {
                    if (postorder[mid + 1] > midNum)
                    {
                        return mid;
                    }
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
