using System;
using System.Collections.Generic;

//https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/27/

namespace C1._007._01_加一
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] a = { 9 };
            Console.WriteLine($"[{string.Join(',', s.PlusOne(a))}]");
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 击败了25%
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>(digits);

            int lastIndex = result.Count - 1;
            while (lastIndex >= 0)
            {
                result[lastIndex]++;
                if (result[lastIndex] == 10)
                {
                    if (lastIndex == 0)
                        result[lastIndex] = 1;
                    else
                        result[lastIndex] = 0;
                   
                    lastIndex--;
                }
                else { break; }
            }
            if (lastIndex == -1)
                result.Add(0);

            return result.ToArray();
        }
    }
}
