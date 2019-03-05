using System;
using System.Collections.Generic;

namespace C1._005._01_只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = { 2, 2, 1,1,3 };

            Console.WriteLine(s.SingleNumber(a));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 击败了84.56%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            Dictionary<int, int> kv = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i];
                if (!kv.ContainsKey(cur))
                {
                    kv.Add(cur, 1);
                }
                else
                {
                    kv[cur] += 1;
                }
            }
            foreach (var item in kv)
            {
                if (item.Value == 1) return item.Key;
            }
            return nums[0];
        }

        /// <summary>
        /// 81.62%
        /// 击败了84.56%的用户（与上面相比，只是消耗内存小了一点点）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            //异或：相同为0，不同为1. 异或同一个数两次，原数不变。
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
