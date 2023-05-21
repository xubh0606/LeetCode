using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _80_RemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            int index = 0;
            int end = 0;
            while (index < len - 1)
            {
                if (nums[index] == nums[index + 1])
                {
                    int temp = nums[index];
                    if (index == end)
                    {
                        end += 2;
                        index += 2;
                    }
                    else
                    {
                        nums[end] = nums[index];
                        end++;
                        index++;
                        nums[end] = nums[index];
                        end++;
                        index++;
                    }
                    while (index < len && nums[index] == temp)
                    {
                        index++;
                    }
                }
                else
                {
                    nums[end] = nums[index];
                    end++;
                    index++;
                }
            }
            if (index < len)
            {
                nums[end] = nums[index];
                end++;
                index++;
            }
            return end;
        }
    }
}
