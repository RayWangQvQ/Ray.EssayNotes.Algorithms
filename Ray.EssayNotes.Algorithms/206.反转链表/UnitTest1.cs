using System;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest206

    {
        [Fact]
        public void Test1()
        {

        }

        /// <summary>
        /// ��ת�����ݹ飩
        /// </summary>
        /// <param name="head"></param>
        /// <returns>����ͷ���</returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;

            //1.��ת��ǰ���֮������н��
            var last = ReverseList(head.next);

            //2.����ǰ�����������
            head.next.next = head;
            head.next = null;

            return last;
        }

        /// <summary>
        /// ��ת����˫ָ�������
        /// </summary>
        /// <param name="head"></param>
        /// <returns>����ͷ���</returns>
        public ListNode ReverseList2(ListNode head)
        {
            ListNode pre = null, current = head;
            while (current != null)
            {
                ListNode temp = current.next;//�����ʵ����Ҫ��3��ָ�룬������ʱ����
                current.next = pre;
                pre = current;
                current = temp;
            }
            return pre;
        }
    }
}
