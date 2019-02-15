using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//https://leetcode-cn.com/explore/learn/card/queue-stack/217/queue-and-bfs/870/

/*

         B  --- E      
      '        '
    '       ' 
  A ---- C  ------ F
    .                 ' .
      .                 G
        D  ----------- '




   */
namespace _004.广度优先搜索
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node G = new Node("G");

            G.Nexts = new List<Node> { };
            E.Nexts = new List<Node> { };

            F.Nexts = new List<Node> { G };
            D.Nexts = new List<Node> { G };

            B.Nexts = new List<Node> { E };
            C.Nexts = new List<Node> { E, F };

            A.Nexts = new List<Node> { B, C, D };
            Console.WriteLine(solution.BFS(A, G));
            Console.ReadKey();

        }
    }

    class Solution
    {
        /// <summary>
        /// Return the length of the shortest path between root and target node.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int BFS(Node root, Node target)
        {
            Queue queue = new Queue(); // store all nodes which are waiting to be processed
            List<Node> used = new List<Node>();          // store all the used nodes
            int step = 0;              // number of steps needed from root to current node

            // initialize
            queue.Enqueue(root);
            used.Add(root);

            // BFS
            while (queue.Count > 0)
            {
                step++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node cur = (Node)queue.Peek();
                    if (cur.Value == target.Value) return step;
                    foreach (Node node in cur.Nexts)
                        if (!used.Contains(node))
                            queue.Enqueue(node);
                    queue.Dequeue();
                }
            }
            return -1;
        }
    }

    class Node
    {
        public string Value;
        public List<Node> Nexts;

        public Node(string value)
        {
            this.Value = value;
        }
    }
}
