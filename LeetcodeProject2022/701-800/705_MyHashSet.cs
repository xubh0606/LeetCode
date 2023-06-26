
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._701_800
{
    public class _705_MyHashSet
    {
        float m_loadFactor;
        int m_InitialSize;
        bucket[] m_buckets;
        int m_loadSize;
        bool m_isWriterInProgress;

        private struct bucket
        {
            public object? key;
            public object? val;
            public int hash_coll;
        }
        public _705_MyHashSet()
        {

        }
        public _705_MyHashSet(int capacity, float loadFactor)
        {
            if(capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }
            if(!(loadFactor >= 0.1f && loadFactor <= 1.0f))
            {
                throw new ArgumentOutOfRangeException(nameof(loadFactor));
            }
            m_loadFactor = 0.72f * loadFactor;
            double rawSize = capacity / m_loadFactor;
            if(rawSize > int.MaxValue)
            {
                throw new ArgumentException(nameof(capacity));
            }
            int hashSize = rawSize > m_InitialSize ? HashHelpers.GetPrime((int)rawSize) : m_InitialSize;
            m_buckets = new bucket[hashSize];
            m_loadSize = (int)(m_loadFactor * hashSize);
            m_isWriterInProgress = false;
            System.Diagnostics.Debug.Assert(m_loadSize < hashSize, "Invalid hashtable loadsize!");
        }
        private int GetHash(object key)
        {
            return int.Parse(key.ToString());
        }

        private uint InitHash(object key, int hashSize, out uint seed, out uint incr)
        {
            uint hashcode = (uint)GetHash(key) & 0x7FFFFFFF;
            seed = (uint)hashcode;
            incr = (uint)(1 + ((seed * HashHelpers.HashPrime) % ((uint)hashSize - 1)));
            return hashcode;
        }

        public void Add(int key)
        {

        }

        public void Remove(int key)
        {

        }

        public bool Contains(int key)
        {
            return true;
        }

        private class HashHelpers
        {
            //按照网上教程补充
            public const int MaxPrimeArrayLength = 0x7FFFFFC3;
            //获取最小长度为101
            public const int HashPrime = 101;
            public static int ExpandPrime(int oldSize)
            {
                //新值为原来的两倍
                int newSize = 2 * oldSize;
                //判断是否大于指定最大值
                if((uint)newSize > MaxPrimeArrayLength && MaxPrimeArrayLength > oldSize)
                {
                    Debug.Assert(MaxPrimeArrayLength == GetPrime(MaxPrimeArrayLength), "Invalid MaxPrimeArrayLength");
                    return MaxPrimeArrayLength;
                }
                return GetPrime(newSize);
            }
            public static int GetPrime(int min)
            {
                //按照素数合集进行寻找
                if(min < 0)
                {
                    throw new ArgumentException("Overflow");
                }
                //获取第一个大于min的素数
                foreach(int prime in m_primes)
                {
                    if(prime >= min)
                    {
                        return prime;
                    }
                    for(int i = (min | 1); i < int.MaxValue; i += 2)
                    {
                        if(IsPrime(i) && (i-1) % HashPrime != 0)
                        {
                            return i;
                        }
                    }
                }
                return min;
            }
            private static readonly int[] m_primes =
            {
                3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919,
    1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591,
    17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437,
    187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263,
    1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369
            };

            public static bool IsPrime(int candidate)
            {
                if((candidate & 1) != 0)
                {
                    int limit = (int)Math.Sqrt(candidate);
                    for(int divisor = 3; divisor <= limit; divisor += 2)
                    {
                        if((candidate % divisor) == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return candidate == 2;
            }
        }
    }
}
