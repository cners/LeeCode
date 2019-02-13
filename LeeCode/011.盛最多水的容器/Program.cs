//题目：https://leetcode-cn.com/problems/container-with-most-water/

using System;

namespace _011.盛最多水的容器
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 }; // 预计结果：49
            Console.WriteLine($"最大面积：{MaxArea(height)}");

            Console.ReadKey();
        }

        static int MaxArea(int[] height)
        {
            ////暴力法，耗时：2360 ms
            //int maxArea = 0;
            //for (int i = 0; i < height.Length; i++)
            //    for (int j = i + 1; j < height.Length; j++)
            //        maxArea = Math.Max(maxArea, Math.Min(height[i], height[j]) * (j - i));
            //return maxArea;


            // 双指针法，耗时：228ms
            int maxArea = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] < height[r])
                    l++;
                else
                    r--;
            }
            return maxArea;
        }
    }
}
//官方解题：https://leetcode-cn.com/problems/container-with-most-water/solution/
