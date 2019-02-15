using System;


//循环队列
//（1）固定大小的数组
//（2）两个指针；标识起始位置和结束位置

//https://leetcode-cn.com/explore/learn/card/queue-stack/216/queue-first-in-first-out-data-structure/866/

namespace _002.循环队列
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue q = new MyCircularQueue(3);
            Console.WriteLine(q.EnQueue(2));
            Console.WriteLine(q.Rear().ToString());
            Console.WriteLine(q.Front());
            Console.WriteLine(q.DeQueue());
            Console.WriteLine(q.Front());
            Console.WriteLine(q.DeQueue());
            Console.WriteLine(q.Front());
            Console.WriteLine(q.EnQueue(4));
            Console.WriteLine(q.EnQueue(2));
            Console.WriteLine(q.EnQueue(2));
            Console.WriteLine(q.EnQueue(3));


            Console.ReadKey();
        }
    }


    public class MyCircularQueue
    {
        /// <summary>
        /// 队列数组 
        /// </summary>
        private int[] _queue;
        /// <summary>
        /// 队首索引
        /// </summary>
        private int _front = 0;
        /// <summary>
        /// 队尾索引
        /// </summary>
        private int _rear = 0;

        /// <summary>
        /// 队列容量
        /// </summary>
        private int _capacity = 0;

        /// <summary>
        /// 队列当前数据元素个数
        /// </summary>
        private int _count = 0;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            if (k < 1) return;

            _queue = new int[k];
            _front = _rear = 0;
            _capacity = k;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            _rear = GetNextRear();
            _queue[_rear] = value;
            _count++;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            _front = GetNextFront();
            _count--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty()) return -1;
            return _queue[GetNextFront()];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty()) return -1;
            return _queue[_rear];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return _count == _capacity;
        }

        public int GetNextRear()
        {
            return (_rear + 1) % _capacity;
        }

        public int GetNextFront()
        {
            return (_front + 1) % _capacity;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
