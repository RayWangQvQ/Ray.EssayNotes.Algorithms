using System;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        /// <summary>
        /// ��ת��������
        /// </summary>
        /// <param name="head"></param>
        /// <returns>����ͷ���</returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            //1.��ת��ǰ���֮������н��
            var last = ReverseList(head.next);

            //2.����ǰ�����������
            head.next.next = head;
            head.next = null;

            return last;
        }
    }
}
