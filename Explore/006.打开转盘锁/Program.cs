using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://leetcode-cn.com/explore/learn/card/queue-stack/217/queue-and-bfs/873/


//解题思路：https://blog.csdn.net/QingyunAlgo/article/details/80589440

namespace _006.打开转盘锁
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deadends = { "0201", "0101", "0102", "1212", "2002" };
            string target = "0202";

            Solution s = new Solution();
            Console.WriteLine(s.OpenLock(deadends, target));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        /// <summary>
        /// 广度优先搜索|速度慢
        /// BFS，
        /// </summary>
        public int OpenLock1(string[] deadends, string target)
        {
            List<string> dead = new List<string>(deadends);
            dead.Sort();

            List<string> visited = new List<string>();
            string init = "0000";
            if (dead.Contains(init) || dead.Contains(target))
                return -1;

            Queue q1 = new Queue();
            Queue q2 = new Queue();
            int steps = 0;
            q1.Enqueue(init);
            while (q1.Count > 0)
            {
                string cur = q1.Dequeue().ToString();
                if (cur == target)
                    return steps;

                foreach (string next in GetNexts(cur))
                {
                    if (!dead.Contains(next) && !visited.Contains(next))
                    {
                        visited.Add(next);
                        q2.Enqueue(next);
                    }
                }

                if (q1.Count == 0)
                {
                    steps++;
                    q1 = q2;
                    q2 = new Queue();
                }
            }

            return -1;
        }

        /// <summary>
        /// 双向广度优先搜索|速度其次慢
        /// BFS
        /// </summary>
        public int OpenLock2(string[] deadends, string target)
        {
            List<string> dead = new List<string>(deadends);
            dead.Sort();

            HashSet<string> visited = new HashSet<string>();
            string init = "0000";
            if (dead.Contains(init) || dead.Contains(target))
                return -1;
            if (target == init)
                return 0;


            HashSet<string> q1 = new HashSet<string>();
            HashSet<string> q2 = new HashSet<string>();
            q1.Add(init);
            q2.Add(target);

            int steps = 0;
            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Count > q2.Count)
                {
                    HashSet<string> temp = q1;
                    q1 = q2;
                    q2 = temp;
                }
                HashSet<string> q3 = new HashSet<string>();
                foreach (string cur in q1)
                {
                    foreach (string next in GetNexts(cur))
                    {
                        if (q2.Contains(next))
                            return steps + 1;

                        if (!dead.Contains(next) && !visited.Contains(next))
                        {
                            visited.Add(next);
                            q3.Add(next);
                        }
                    }
                }
                steps++;
                q1 = q3;
            }

            return -1;
        }
        private string[] GetNexts(string cur)
        {
            HashSet<string> nexts = new HashSet<string>();
            for (int i = 0; i < cur.Length; i++)
            {
                StringBuilder builder = new StringBuilder(cur);
                builder[i] = cur[i] == '0' ? '9' : (char)(cur[i] - 1);
                nexts.Add(builder.ToString());

                builder = new StringBuilder(cur);
                builder[i] = cur[i] == '9' ? '0' : (char)(cur[i] + 1);
                nexts.Add(builder.ToString());
            }
            return nexts.ToArray();
        }


        /// <summary>
        /// 速度很快
        /// </summary>
        /// <param name="deadends"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int OpenLock(string[] deadends, string target)
        {
            if (deadends == null || target == null)
            {
                return -1;
            }

            var visited = new Dictionary<string, int>();
            foreach (var deadend in deadends)
            {
                if (!visited.ContainsKey(deadend))
                {
                    visited.Add(deadend, int.MaxValue);
                }
            }

            if (visited.ContainsKey(target) || visited.ContainsKey("0000"))
            {
                return -1;
            }

            var queue = new Queue<string>();
            queue.Enqueue("0000");
            visited.Add("0000", 0);
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current == target)
                {
                    return visited[current];
                }

                var nexts = GetNexts(current);
                foreach (var next in nexts)
                {
                    if (!visited.ContainsKey(next))
                    {
                        queue.Enqueue(next);
                        visited.Add(next, visited[current] + 1);
                    }
                }
            }

            return -1;
        }

        //public string[] GetNexts(string num)
        //{
        //    var candidates = new List<string>();
        //    var ops = new int[] { -1, 1 };
        //    for (int i = 0; i < 4; i++)
        //    {
        //        var candidate = num.ToCharArray();
        //        var digit = candidate[i] - '0';
        //        foreach (var op in ops)
        //        {
        //            candidate[i] = (char)((digit + 10 + op) % 10 + '0');
        //            candidates.Add(new string(candidate));
        //        }
        //    }

        //    return candidates.ToArray();
        //}
    }


}
