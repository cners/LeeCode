using System;
using System.Collections.Generic;
//https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/23/

namespace C1._003._01_旋转数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            s.Rotate(a, k);

            Console.WriteLine($"[{string.Join(',', a)}]");

            Console.ReadKey();
        }
    }
    public class Solution
    {
        /// <summary>
        /// 解法1
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate1(int[] nums, int k)
        {
            if (nums.Length == 0) return;
            k = k % nums.Length;
            for (int i = 1; i <= k; i++)
            {
                int lastVal = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastVal;
            }
        }

        /// <summary>
        /// 超过了61.26%
        /// 先整体移动后面要向前面去的几个节点，再移动前面往后移动
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            int len = nums.Length;
            k = k % len;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
            {
                stack.Push(nums[len - 1 - i]);
            }
            for (int i = len - 1 - k; i >= 0; i--)
            {
                nums[i + k] = nums[i];
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = stack.Pop();
            }
        }
    }
}
