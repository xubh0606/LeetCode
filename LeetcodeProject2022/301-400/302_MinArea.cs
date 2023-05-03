using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    //给你一个大小为 m x n 的二进制矩阵 image 表示一张黑白图片，0 代表白色像素，1 代表黑色像素。

    //黑色像素相互连接，也就是说，图片中只会有一片连在一块儿的黑色像素。像素点是水平或竖直方向连接的。

    //给你两个整数 x 和 y 表示某一个黑色像素的位置，请你找出包含全部黑色像素的最小矩形（与坐标轴对齐），并返回该矩形的面积。

    public class _302_MinArea
    {
        int left;
        int right;
        int up;
        int down;
        public int MinArea(char[][] image, int x, int y)
        {
            left = 0;
            right = image[0].Length - 1;
            up = 0;
            down = image.Length - 1;
            if (right > down)
            {
                SearchLeft(left, y, image);
                SearchRight(y, right, image);
                SearchUp(up, x, image);
                SearchDown(x, down, image);
            }
            else
            {
                SearchUp(up, x, image);
                SearchDown(x, down, image);
                SearchLeft(left, y, image);
                SearchRight(y, right, image);
            }
            return (right - left + 1) * (down - up + 1);
        }

        void SearchUp(int edgeUp, int edgeDown, char[][] image)
        {
            if (edgeDown == edgeUp)
            {
                up = edgeDown;
                return;
            }
            int mid = (edgeDown - edgeUp) / 2 + edgeUp;
            bool isBlack = false;
            for (int i = left; i <= right; i++)
            {
                if (image[mid][i] == '1')
                {
                    isBlack = true;
                    break;
                }
            }
            if (isBlack)
            {
                SearchUp(edgeUp, mid, image);
            }
            else
            {
                SearchUp(mid + 1, edgeDown, image);
            }
        }

        void SearchDown(int edgeUp, int edgeDown, char[][] image)
        {
            if (edgeDown == edgeUp)
            {
                down = edgeDown;
                return;
            }
            int mid = (edgeDown - edgeUp + 1) / 2 + edgeUp;
            bool isBlack = false;
            for (int i = left; i <= right; i++)
            {
                if (image[mid][i] == '1')
                {
                    isBlack = true;
                    break;
                }
            }
            if (isBlack)
            {
                SearchDown(mid, edgeDown, image);
            }
            else
            {
                SearchDown(edgeUp, mid - 1, image);
            }
        }

        void SearchLeft(int edgeLeft, int edgeRight, char[][] image)
        {
            if (edgeLeft == edgeRight)
            {
                left = edgeLeft;
                return;
            }
            int mid = (edgeRight - edgeLeft) / 2 + edgeLeft;
            bool isBlack = false;
            for (int i = up; i <= down; i++)
            {
                if (image[i][mid] == '1')
                {
                    isBlack = true;
                    break;
                }
            }
            if (isBlack)
            {
                SearchLeft(edgeLeft, mid, image);
            }
            else
            {
                SearchLeft(mid + 1, edgeRight, image);
            }
        }

        void SearchRight(int edgeLeft, int edgeRight, char[][] image)
        {
            if (edgeLeft == edgeRight)
            {
                right = edgeLeft;
                return;
            }
            int mid = (edgeRight - edgeLeft + 1) / 2 + edgeLeft;
            bool isBlack = false;
            for (int i = up; i <= down; i++)
            {
                if (image[i][mid] == '1')
                {
                    isBlack = true;
                    break;
                }
            }
            if (isBlack)
            {
                SearchRight(mid, edgeRight, image);
            }
            else
            {
                SearchRight(edgeLeft, mid - 1, image);
            }
        }
    }
}
