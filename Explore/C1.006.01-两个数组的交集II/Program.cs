using System;
using System.Collections.Generic;
//https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/26/
namespace C1._006._01_两个数组的交集II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4,9,5 };
            int[] b = { 9,4,9,8,4 };

            Solution s = new Solution();
            var result = s.Intersect(a, b);
            Console.WriteLine($"[{string.Join(',', result)}]");
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 击败了44.12%的用户
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int value in nums1)
            {
                if (!counter.ContainsKey(value))
                    counter.Add(value, 1);
                else
                    counter[value] += 1;
            }

            foreach (int item in nums2)
            {
                if (counter.ContainsKey(item) && counter[item] > 0)
                {
                    counter[item] -= 1;
                    result.Add(item);
                }
                else
                {
                    if (counter.ContainsKey(item))
                    {
                        
                    }
                }
            }
            return result.ToArray();
        }
    }
}
