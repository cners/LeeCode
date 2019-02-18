using System;
using System.Collections.Generic;

namespace _008.栈的实现
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(30);
            stack.Push(4);
            for (int i = 0; i < 4; i++)
            {
                if(!stack.IsEmpty())
                    Console.WriteLine(stack.Top());
                stack.Pop();
            }

            Console.ReadKey();
        }
    }

    class MyStack
    {
        private List<int> data;
        public MyStack()
        {
            data = new List<int>();
        }

        public void Push(int x)
        {
            data.Add(x);
        }

        public bool Pop()
        {
            if (IsEmpty()) return false;
             data.RemoveAt(data.Count-1);
            return true;
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }

        public int Top()
        {
            return data[data.Count - 1];
        }

    }
}
