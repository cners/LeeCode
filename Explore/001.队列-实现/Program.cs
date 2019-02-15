using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//队列 - 实现
//https://leetcode-cn.com/explore/learn/card/queue-stack/216/queue-first-in-first-out-data-structure/863/
//使用动态数组和指向队列头部的索引


//注：本实例提供了一种简单但低效的队列实现

namespace _001.队列_实现
{

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            q.EnQueue(5);
            q.EnQueue(3);

            if (!q.IsEmpty())
                Console.WriteLine(q.Front());

            q.DeQueue();
            if (!q.IsEmpty())
                Console.WriteLine(q.Front());

            q.DeQueue();
            if (!q.IsEmpty())
                Console.WriteLine(q.Front());

            Console.ReadKey();

        }
    }

    class MyQueue
    {
        // store elements
        private List<int> data;

        // a pointer to indicate the start position
        private int p_start;

        public MyQueue()
        {
            data = new List<int>();
            p_start = 0;
        }

        /// <summary>
        /// Insert an element into the queue. Return true if the operation is successful.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool EnQueue(int x)
        {
            data.Add(x);
            return true;
        }

        /// <summary>
        /// Delete an element from the queue. Return true if the operation is successful.
        /// </summary>
        /// <returns></returns>
        public bool DeQueue()
        {
            if (IsEmpty())
                return false;

            p_start++;
            return true;
        }

        /// <summary>
        /// Get the front item fron the queue.
        /// </summary>
        /// <returns></returns>
        public int Front()
        {
            return data[p_start];
        }
        /// <summary>
        /// Checks whether the queue is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return p_start >= data.Count();
        }
    }
}
