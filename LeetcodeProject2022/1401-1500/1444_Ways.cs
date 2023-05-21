using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1444_Ways
    {
        //先建立next矩阵，将每个点的下一个位置标记出来
        //再根据next矩阵每次实现dp，直到k层，记录第k层的全部内容即可
        int MOD = 1000000007;
        public int Ways(string[] pizza, int k)
        {
            int row = pizza.Length;
            int col = pizza[0].Length;
            int[,,] nextCutWithApple = FindNextCutWithApple(pizza);
            int[,,,] cutAppleEachTimes = new int[row, col, k, 2];//纵坐标，横坐标，层数，横向/纵向的来源数量
            if(nextCutWithApple[0, 0, 0] == 0 || k == 1)
            {
                return nextCutWithApple[0, 0, 0];
            }
            int next_1_0 = nextCutWithApple[0, 0, 0];
            int next_1_1 = nextCutWithApple[0, 0, 1];
            if(next_1_0 != 0 && next_1_0 < row)
            {
                cutAppleEachTimes[next_1_0, 0, 1, 0] = 1;
            }
            if (next_1_1 != 0 && next_1_1 < col)
            {
                cutAppleEachTimes[0, next_1_1, 1, 1] = 1;
            }
            for (int p = 1; p < k - 1; p++)
            {
                Update(cutAppleEachTimes, p, nextCutWithApple, row, col);
            }
            return FindAll(cutAppleEachTimes, k - 1, nextCutWithApple, row, col);
        }

        //已知下一次可能的最小切割位置，只需要跳至即可
        //每次记得将左侧多余内容补入(因为上面能切下面一定可切，所以每次只需要记录第一个切割点，后续加上上侧即可)
        void Update(int[,,,] cutAppleEachTimes, int level, int[,,] nextCutWithApple, int row, int col)
        {
            int cur = level;
            int next = level + 1;
            //单独考虑最左侧和最上侧
            for (int j = 1; j < col; j++)
            {
                cutAppleEachTimes[0, j, cur, 1] += cutAppleEachTimes[0, j - 1, cur, 1];
                cutAppleEachTimes[0, j, cur, 1] %= MOD;
                int next_cur_0 = nextCutWithApple[0, j, 0];
                int next_cur_1 = nextCutWithApple[0, j, 1];
                if (next_cur_1 != 0 && next_cur_1 < col)
                {
                    cutAppleEachTimes[0, next_cur_1, next, 1] += cutAppleEachTimes[0, j, cur, 1];
                    cutAppleEachTimes[0, next_cur_1, next, 1] %= MOD;
                }
                if (next_cur_0 != 0 && next_cur_0 < row)
                {
                    cutAppleEachTimes[next_cur_0, j, next, 0] += cutAppleEachTimes[0, j, cur, 1];
                    cutAppleEachTimes[next_cur_0, j, next, 0] %= MOD;
                }
            }
            for (int i = 1; i < row; i++)
            {
                cutAppleEachTimes[i, 0, cur, 0] += cutAppleEachTimes[i - 1, 0, cur, 0];
                cutAppleEachTimes[i, 0, cur, 0] %= MOD;
                int next_cur_0 = nextCutWithApple[i, 0, 0];
                int next_cur_1 = nextCutWithApple[i, 0, 1];
                if (next_cur_1 != 0 && next_cur_1 < col)
                {
                    cutAppleEachTimes[i, next_cur_1, next, 1] += cutAppleEachTimes[i, 0, cur, 0];
                    cutAppleEachTimes[i, next_cur_1, next, 1] %= MOD;
                }
                if (next_cur_0 != 0 && next_cur_0 < row)
                {
                    cutAppleEachTimes[next_cur_0, 0, next, 0] += cutAppleEachTimes[i, 0, cur, 0];
                    cutAppleEachTimes[next_cur_0, 0, next, 0] %= MOD;
                }
            }
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    //每次先补入左侧和上侧的未加入数字
                    cutAppleEachTimes[i, j, cur, 0] += cutAppleEachTimes[i - 1, j, cur, 0];
                    cutAppleEachTimes[i, j, cur, 0] %= MOD;
                    cutAppleEachTimes[i, j, cur, 1] += cutAppleEachTimes[i, j - 1, cur, 1];
                    cutAppleEachTimes[i, j, cur, 1] %= MOD;
                    //判断是否有下一次切割，如果没有直接抛弃，有则进行添加
                    int next_cur_0 = nextCutWithApple[i, j, 0];
                    int next_cur_1 = nextCutWithApple[i, j, 1];
                    int total = cutAppleEachTimes[i, j, cur, 0] + cutAppleEachTimes[i, j, cur, 1];
                    if (next_cur_1 != 0 && next_cur_1 < col)
                    {
                        cutAppleEachTimes[i, next_cur_1, next, 1] += total;
                        cutAppleEachTimes[i, next_cur_1, next, 1] %= MOD;
                    }
                    if (next_cur_0 != 0 && next_cur_0 < row)
                    {
                        cutAppleEachTimes[next_cur_0, j, next, 0] += total;
                        cutAppleEachTimes[next_cur_0, j, next, 0] %= MOD;
                    }
                }
            }
        }

        int FindAll(int[,,,] cutAppleEachTimes, int k, int[,,] nextCutWithApple, int row, int col)
        {
            //最后一层，计算存在下一步(防止最后一片上面没苹果)的总数目
            //基本结构与update一样，但是进入下一层变为直接增加总值
            int sum = 0;
            //单独考虑最左侧和最上侧
            for (int j = 1; j < col; j++)
            {
                cutAppleEachTimes[0, j, k, 1] += cutAppleEachTimes[0, j - 1, k, 1];
                cutAppleEachTimes[0, j, k, 1] %= MOD;
                if (nextCutWithApple[0, j, 0] == 0 && nextCutWithApple[0, j, 1] == 0)
                {
                    continue;
                }
                else
                {
                    sum += cutAppleEachTimes[0, j, k, 1];
                    sum %= MOD;
                }
            }
            for (int i = 1; i < row; i++)
            {
                cutAppleEachTimes[i, 0, k, 0] += cutAppleEachTimes[i - 1, 0, k, 0];
                cutAppleEachTimes[i, 0, k, 0] %= MOD;
                if (nextCutWithApple[i, 0, 0] == 0 && nextCutWithApple[i, 0, 1] == 0)
                {
                    continue;
                }
                else
                {
                    sum += cutAppleEachTimes[i, 0, k, 0];
                    sum %= MOD;
                }
            }
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    //每次先补入左侧和上侧的未加入数字
                    cutAppleEachTimes[i, j, k, 0] += cutAppleEachTimes[i - 1, j, k, 0];
                    cutAppleEachTimes[i, j, k, 0] %= MOD;
                    cutAppleEachTimes[i, j, k, 1] += cutAppleEachTimes[i, j - 1, k, 1];
                    cutAppleEachTimes[i, j, k, 1] %= MOD;
                    //判断是否有下一次切割，如果没有直接抛弃，有则进行添加
                    int total = cutAppleEachTimes[i, j, k, 0] + cutAppleEachTimes[i, j, k, 1];
                    total %= MOD;
                    if (nextCutWithApple[i, j, 0] == 0 && nextCutWithApple[i, j, 1] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sum += total;
                        sum %= MOD;
                    }
                }
            }
            return sum;
        }

        int[,,] FindNextCutWithApple(string[] pizza)
        {
            int row = pizza.Length;
            int col = pizza[0].Length;
            int[,,] nextCutWithApple = new int[row, col, 2];//分别是0:纵向下一个位置和1:横向下一个位置
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (pizza[i][j] == 'A')
                    {
                        InsertNode(nextCutWithApple, i, j);
                    }
                }
            }
            return nextCutWithApple;
        }

        //每当左上角存在空位置，添加当前苹果位置+1
        void InsertNode(int[,,] nextCutWithApple, int row, int col)
        {
            for (int i = row; i >= 0; i--)
            {
                if (nextCutWithApple[i, col, 0] == 0 || nextCutWithApple[i, col, 0] > row + 1)
                {
                    for (int j = col; j >= 0; j--)
                    {
                        if (nextCutWithApple[i, j, 0] == 0 || nextCutWithApple[i, j, 0] > row + 1)
                        {
                            nextCutWithApple[i, j, 0] = row + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            for (int j = col; j >= 0; j--)
            {
                if (nextCutWithApple[row, j, 1] == 0 || nextCutWithApple[row, j, 1] > col + 1)
                {
                    for (int i = row; i >= 0; i--)
                    {
                        if (nextCutWithApple[i, j, 1] == 0 || nextCutWithApple[i, j, 1] > col + 1)
                        {
                            nextCutWithApple[i, j, 1] = col + 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
