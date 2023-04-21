using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
 //* // This is the interface that allows for creating nested lists.
 //* // You should not implement it, or speculate about its implementation
 //* interface NestedInteger
 //       {
 //*
 //*     // Constructor initializes an empty nested list.
 //*     public NestedInteger();
 //*
 //*     // Constructor initializes a single integer.
 //*     public NestedInteger(int value);
 //*
 //*     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 //*     bool IsInteger();
 //*
 //*     // @return the single integer that this NestedInteger holds, if it holds a single integer
 //*     // Return null if this NestedInteger holds a nested list
 //*     int GetInteger();
 //*
 //*     // Set this NestedInteger to hold a single integer.
 //*     public void SetInteger(int value);
 //*
 //*     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 //*     public void Add(NestedInteger ni);
 //*
 //*     // @return the nested list that this NestedInteger holds, if it holds a nested list
 //*     // Return null if this NestedInteger holds a single integer
 //*     IList<NestedInteger> GetList();
 //* }
 //*/
    public class _385_Deserialize
    {
        //int index = 0;
        //    public NestedInteger Deserialize(string s)
        //    {
        //        if (s[index] != '[')
        //        {
        //            bool negative = false;
        //            if (s[index] == '-')
        //            {
        //                negative = true;
        //                index++;
        //            }
        //            int n = 0;
        //            while (index < s.Length && s[index] != ',' && s[index] != '[')
        //            {
        //                n = n * 10 + (s[index] - '0');
        //                index++;
        //            }
        //            if (negative == true)
        //            {
        //                n = n * -1;
        //            }
        //            return new NestedInteger(n);
        //        }
        //        else
        //        {
        //            index++;
        //            bool negative = false;
        //            if (s[index] == '-')
        //            {
        //                negative = true;
        //                index++;
        //            }
        //            int n = 0;
        //            while (index < s.Length && s[index] != ',' && s[index] != '[')
        //            {
        //                n = n * 10 + (s[index] - '0');
        //                index++;
        //            }
        //            if (negative == true)
        //            {
        //                n = n * -1;
        //            }
        //            NestedInteger ni = new NestedInteger(n);
        //            if (index == s.Length)
        //            {
        //                return ni;
        //            }
        //            else if (s[index + 1] == ']')
        //            {
        //                return ni;
        //            }
        //            else
        //            {
        //                index += 1;
        //                ni.Add(Deserialize(s));
        //                return ni;
        //            }
        //        }

    //    }
    }
}

