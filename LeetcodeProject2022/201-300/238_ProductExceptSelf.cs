using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _238_ProductExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            //获取0-n和n-len的总数据
            int n = nums.Length;
            int[] saveLeft = new int[n - 1];
            int[] saveRight = new int[n];
            saveLeft[0] = nums[0];
            saveRight[n - 1] = nums[n - 1];
            for (int i = 1; i < n - 1; i++)
            {
                saveLeft[i] = saveLeft[i - 1] * nums[i];
            }
            for (int j = n - 2; j > 0; j--)
            {
                saveRight[j] = saveRight[j + 1] * nums[j];
            }
            int[] answer = new int[n];
            for (int i = 1; i < n - 1; i++)
            {
                answer[i] = saveLeft[i - 1] * saveRight[i + 1];
            }
            answer[0] = saveRight[1];
            answer[n - 1] = saveLeft[n - 2];
            return answer;
        }
    }
}
