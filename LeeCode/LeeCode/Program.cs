/*
 *
 题库链接：https://leetcode-cn.com/problems/add-two-numbers/solution/

给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807 

 */
using System;
using System.Collections.Generic;

namespace LeeCode
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 第一个链表
            ListNode dummyHead = new ListNode(3);
            var l12 = new ListNode(4);
            dummyHead.next = l12;

            var l13 = new ListNode(2);
            l12.next = l13;

            l13.next = null;


            // 第二个链表
            ListNode dummyHead2 = new ListNode(5);
            var l22 = new ListNode(6);
            dummyHead2.next = l22;

            var l23 = new ListNode(4);
            l22.next = l23;

            l23.next = null;

            // 相加
            var result = AddTwoNumbers(dummyHead, dummyHead2);

            // 展示结果
            var curr = result;
            while (true)
            {
                if (curr == null) break;
                Console.Write(curr.val);
                curr = curr.next;

            }
            Console.ReadKey();
        }

        /// <summary>
        /// 两个链表相加
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;

                int sum = carry + x + y;
                carry = sum / 10;

                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }
}
