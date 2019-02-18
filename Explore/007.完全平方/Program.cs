using System;
using System.Collections.Generic;

//https://leetcode-cn.com/explore/learn/card/queue-stack/217/queue-and-bfs/874/


namespace _007.完全平方
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NumSquares(12));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 四方定理|速度最快，击败了100%的用户
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares1(int n)
        {
            while (n % 4 == 0) n /= 4;
            if (n % 8 == 7) return 4;

            int a = 0;
            while (a * a <= n)
            {
                int b = (int)Math.Sqrt(n - a * a);
                if (a * a + b * b == n)
                {
                    if (a != 0 && b != 0)return 2;
                    else return 1;
                }
                a++;
            }
            return 3;
        }

        public int NumSquares(int n)
        {
            HashSet<int> hashset = new HashSet<int>();

            Queue<int> queue = new Queue<int>();
            int level = 0;
            queue.Enqueue(n);

            while (queue.Count!=0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int cur = queue.Dequeue();
                    int sqrtedV = (int)Math.Floor(Math.Sqrt(cur));
                    for (int j = sqrtedV; j >0; j--)
                    {
                        int a = cur - j * j;
                        if (a == 0) return level + 1;

                        if (!hashset.Contains(a))
                        {
                            hashset.Add(a);
                            queue.Enqueue(a);
                        }
                    }
                }
                level++;
            }
            return 0;
        }
    }
}
