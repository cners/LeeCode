using System;
using System.Collections.Generic;
//https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/21/

namespace C1._001._01_从排序数组中删除重复项
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2 };//{ 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Solution s = new Solution();
            int length = s.RemoveDuplicates(a);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 垃圾，只击败了1.40%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates1(int[] nums)
        {
            int index = 0;

            Dictionary<int, int> a = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!a.ContainsValue(nums[i]))
                {
                    nums[index] = nums[i];
                    a.Add(index++, nums[i]);
                }
            }
            return a.Count;
        }

        /// <summary>
        /// 跟第一名一样，但是呢，击败了21.96%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[index] != nums[i])
                    nums[++index] = nums[i];
            }
            return index + 1;
        }
    }
}
