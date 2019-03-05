using System;

//https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/22/

namespace C1._002._01_买卖股票的最佳时机II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 7, 1, 5, 3, 6, 4 };
            price = new int[] { 1, 2, 3, 4, 5 };

            Solution s = new Solution();
            Console.WriteLine(s.MaxProfit(prices: price));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                int differ = prices[i + 1] - prices[i];
                if (differ > 0)
                    maxProfit += differ;
            }
            return maxProfit;
        }
    }
}
