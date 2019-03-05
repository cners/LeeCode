using System;
using System.Collections.Generic;

namespace C1._004._01_存在重复
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = { 1, 2, 3, 1 };
            Console.WriteLine(s.ContainsDuplicate(a).ToString().ToLower());
            Console.ReadKey();
        }
    }
    public class Solution
    {
        /// <summary>
        /// 战胜了84.01%的用户
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0) return false;
            HashSet<int> n = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (n.Contains(nums[i])) return true;
                n.Add(nums[i]);
            }
            return false;
        }
    }
}
