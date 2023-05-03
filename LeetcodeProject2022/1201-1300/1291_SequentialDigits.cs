using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1201_1300
{
    public class _1291_SequentialDigits
    {public IList<int> SequentialDigits(int low, int high) {
        IList<int> list = new List<int>();
        int temp = 0;
        for(int len = 1; len < 9; len++){
            for(int firstDigit = 1; firstDigit < 10-len; firstDigit++){
                int count = 1;
                temp = firstDigit;
                while(count <= len){
                    temp = temp*10 + temp%10+1;//替换为顺次的下一个数
                    count++;
                }
                if(temp > high){
                    break;
                }
                if(temp >= low){
                    list.Add(temp);
                }
            }
            if(temp > high){
                break;
            }
        }
        return list;
    }
    }
}
