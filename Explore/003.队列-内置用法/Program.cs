using System;
using System.Collections;

//https://leetcode-cn.com/explore/learn/card/queue-stack/216/queue-first-in-first-out-data-structure/867/

namespace _003.队列_内置用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            // Get the first element without removing it, Return null if queue is empty.
            if(q.Count>0)
            Console.WriteLine(q.Peek());

            q.Enqueue(5);
            q.Enqueue(13);
            q.Enqueue(8);
            q.Enqueue(6);

            Console.WriteLine(q.Dequeue());//5,removing it
            Console.WriteLine(q.Peek());//13
            Console.WriteLine(q.Peek());//13


            Console.ReadKey();
        }
    }
}
