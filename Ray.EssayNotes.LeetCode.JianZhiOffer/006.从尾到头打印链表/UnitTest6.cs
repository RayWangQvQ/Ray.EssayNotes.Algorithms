using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest6
    {
        [Fact]
        public void Test1()
        {

        }

        public int[] ReversePrint(ListNode head)
        {
            //˼·:ѭ��������ӵ�ջ�У�Ȼ��ת��Ϊ���鷵��

            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            return stack.ToArray();
        }
    }
}
