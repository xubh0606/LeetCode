using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _44_IsMatch
    {
        //递归考虑
        public bool IsMatch(string s, string p)
        {
            //先处理干净前后部分
            int leftS = 0;
            int rightS = s.Length;
            int leftP = 0;
            int rightP = p.Length;
            //前部
            while (leftS < rightS && leftP < rightP)
            {
                if (s[leftS] == p[leftP] || p[leftP] == '?')
                {
                    leftS++;
                    leftP++;
                }
                else
                {
                    break;
                }
            }
            //此时留下可能性：p到头^，p出现*号，匹配失败， s到头(包含在p*中)，sp同时到头^
            if (leftP == rightP)
            {
                if (leftS == rightS)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (p[leftP] != '*')
            {
                return false;
            }
            //判断完毕，开始考虑*,进递归
            return IsMatchRemain(s, p, leftS, leftP);

        }
        bool IsMatchRemain(string s, string p, int leftS, int leftP)
        {
            //每次确认p之间的内容是否在s中找到匹配，其中如果有star就进下层递归，否则确认能否和s尾部匹配
            string inP = "";
            leftP++;
            while (leftP < p.Length && p[leftP] != '*')
            {
                inP += p[leftP];
                leftP++;
            }
            if (leftP == p.Length)
            {
                if (inP == "")
                {
                    return true;
                }
                return CheakEnd(inP, s, leftS);
            }
            else
            {
                if (inP == "")
                {
                    return IsMatchRemain(s, p, leftS, leftP);
                }
                int new_leftS = CheakIn(inP, s, leftS);
                if (new_leftS == -1)
                {
                    return false;
                }
                return IsMatchRemain(s, p, new_leftS, leftP);
            }
            throw new Exception();
        }
        int CheakIn(string inP, string s, int leftS)
        {
            for (int i = leftS; i < s.Length - inP.Length; i++)
            {
                if (IsSame(s, inP, i))
                {
                    return i + inP.Length;
                }
            }
            return -1;
        }
        bool IsSame(string s, string inP, int leftS)
        {
            int leftP = 0;
            while (leftP < inP.Length)
            {
                if (s[leftS] == inP[leftP] || inP[leftP] == '?')
                {
                    leftP++;
                    leftS++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        bool CheakEnd(string inP, string s, int leftS)
        {
            if (s.Length - leftS < inP.Length)
            {
                return false;
            }
            int rightP = inP.Length - 1;
            int rightS = s.Length - 1;
            while (rightP >= 0)
            {
                if (s[rightS] == inP[rightP] || inP[rightP] == '?')
                {
                    rightP--;
                    rightS--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        //bool m_isWrong;
        //int lastEnd;
        //int totalEnd;
        //public bool IsMatch(string s, string p)
        //{
        //    m_isWrong = false;
        //    IList<int> saveStar = FindStar(p);
        //    //存储2个*中间的内容，匹配成功则返回真，无法匹配或没有2个*则单独讨论
        //    if (saveStar.Count == 0)
        //    {
        //        Cheak(s, p, 0, s.Length, 0, p.Length);
        //        return !m_isWrong;
        //    }
        //    else if (saveStar.Count == 1)
        //    {
        //        Cheak(s, p, 0, saveStar[0], 0, saveStar[0]);
        //        if (m_isWrong)
        //        {
        //            return false;
        //        }
        //        lastEnd = saveStar[0] > 0 ? saveStar[0] : 0;
        //        int startP = saveStar[saveStar.Count - 1] + 1;
        //        if (s.Length - p.Length + startP < lastEnd)
        //        {
        //            return false;
        //        }
        //        Cheak(s, p, s.Length - p.Length + startP, s.Length, startP, p.Length);
        //        return !m_isWrong;
        //    }
        //    else
        //    {
        //        Cheak(s, p, 0, saveStar[0], 0, saveStar[0]);
        //        if (m_isWrong)
        //        {
        //            return false;
        //        }
        //        lastEnd = saveStar[0] > 0 ? saveStar[0] : 0;
        //        int startP = saveStar[saveStar.Count - 1] + 1;
        //        if (s.Length - p.Length + startP < lastEnd)
        //        {
        //            return false;
        //        }
        //        Cheak(s, p, s.Length - p.Length + startP, s.Length, startP, p.Length);
        //        if (m_isWrong)
        //        {
        //            return false;
        //        }
        //        totalEnd = startP == p.Length ? s.Length : startP;
        //        for (int i = 0; i < saveStar.Count - 1; i++)
        //        {
        //            FindStringBetween(s, p, saveStar[i] + 1, saveStar[i + 1]);
        //            if (m_isWrong)
        //            {
        //                return false;
        //            }
        //        }
        //        return !m_isWrong;
        //    }
        //}
        //IList<int> FindStar(string p)
        //{
        //    IList<int> saveStar = new List<int>();
        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        if (p[i] == '*')
        //        {
        //            saveStar.Add(i);
        //        }
        //    }
        //    return saveStar;
        //}
        //void FindStringBetween(string s, string p, int startP, int endP)
        //{
        //    string temp = "";
        //    for (int i = startP; i < endP; i++)
        //    {
        //        temp += p[i];
        //    }
        //    if (temp == "")
        //    {
        //        return;
        //    }
        //    IsSHaveString(s, temp);
        //}
        //void IsSHaveString(string s, string temp)
        //{
        //    for (int i = lastEnd; i <= totalEnd - temp.Length; i++)
        //    {
        //        if (IsSame(s, temp, i))
        //        {
        //            lastEnd = i + temp.Length;
        //            return;
        //        }
        //    }
        //    m_isWrong = true;
        //}
        //bool IsSame(string s, string temp, int startS)
        //{
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        if (s[startS] == temp[i] || temp[i] == '?')
        //        {
        //            startS++;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //void Cheak(string s, string p, int stratS, int endS, int startP, int endP)
        //{
        //    while (stratS < endS && startP < endP)
        //    {
        //        if (s[stratS] == p[startP] || p[startP] == '?')
        //        {
        //            startP++;
        //            stratS++;
        //        }
        //        else
        //        {
        //            m_isWrong = true;
        //            return;
        //        }
        //    }
        //    if (stratS != endS || startP != endP)
        //    {
        //        m_isWrong = true;
        //    }
        //}
    }
}
