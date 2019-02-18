using System;
using System.Collections.Generic;

namespace _009.内置的栈
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(30);
            s.Push(4);
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empth!");
                Console.ReadKey();
            }

            s.Pop();
            Console.WriteLine($"The top element is :{s.Peek()}");

            Console.WriteLine($"The size is:{s.Count}");

            Console.ReadKey();
        }
    }
}
