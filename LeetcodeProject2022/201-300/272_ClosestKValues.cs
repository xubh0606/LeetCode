using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    //给定二叉搜索树的根 root 、一个目标值 target 和一个整数 k ，返回BST中最接近目标的 k 个值。你可以按 任意顺序 返回答案。
    //题目 保证 该二叉搜索树中只会存在一种 k 个值集合最接近 target
    public class _272_ClosestKValues
    {
        double t;
        public IList<int> ClosestKValues(TreeNode root, double target, int k)
        {
            int[] heapFiy = new int[k];
            t = target;
            Queue<TreeNode> q = new Queue<TreeNode>();
            int count = 0;
            q.Enqueue(root);
            while (count < k)
            {
                TreeNode temp = q.Dequeue();
                heapFiy[count] = temp.val;
                count++;
                TreeNode leftNode = temp.left;
                TreeNode rightNode = temp.right;
                if (leftNode != null)
                {
                    q.Enqueue(leftNode);
                }
                if (rightNode != null)
                {
                    q.Enqueue(rightNode);
                }
            }
            for (int i = (k + 1) / 2 - 1; i >= 0; i--)
            {
                heap(i, k, heapFiy);
            }
            while (q.Count > 0)
            {
                TreeNode temp = q.Dequeue();
                int val = temp.val;
                TreeNode leftNode = temp.left;
                TreeNode rightNode = temp.right;
                if (isCloser(heapFiy[0], val))
                {
                    heapFiy[0] = val;
                    heap(0, k, heapFiy);
                    if (rightNode != null)
                    {
                        q.Enqueue(rightNode);
                    }
                    if (leftNode != null)
                    {
                        q.Enqueue(leftNode);
                    }
                }
                else
                {
                    if (rightNode != null)
                    {
                        q.Enqueue(rightNode);
                    }
                    if (leftNode != null)
                    {
                        q.Enqueue(leftNode);
                    }
                }
            }
            return heapFiy;
        }
        void heap(int i, int n, int[] heapFiy)
        {
            while (i < n)
            {
                int max = i;
                int left = i * 2 + 1;
                int right = i * 2 + 2;
                if (left < n && isCloser(heapFiy[left], heapFiy[i]))
                {
                    max = left;
                }
                if (right < n && isCloser(heapFiy[right], heapFiy[max]))
                {
                    max = right;
                }
                if (i == max)
                {
                    return;
                }
                swap(max, i, heapFiy);
                i = max;
            }
        }
        bool isCloser(int i, int j)
        {
            double ii = Math.Abs(i - t);
            double jj = Math.Abs(j - t);
            return ii > jj;
        }
        void swap(int i, int j, int[] arr)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
