using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest9
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class CQueue
    {
        private Stack<int> _insert;
        private Stack<int> _delete;

        public CQueue()
        {
            //˼·��һ���������룬һ������ɾ��
            _insert = new Stack<int>();
            _delete = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            _insert.Push(value);
        }

        public int DeleteHead()
        {
            int head = 0;

            //����У���ֱ�ӳ�ջ�����û�У���_insertջ��ת��_deleteջ���ٳ�ջ
            if (_delete.Count > 0)
            {
                head = _delete.Peek();
                _delete.Pop();
            }
            else if (_insert.Count == 0)
            {
                return -1;
            }
            else
            {
                InsertToDelete();
                return DeleteHead();
            }

            return head;
        }

        private void InsertToDelete()
        {
            while (_insert.Count > 0)
            {
                _delete.Push(_insert.Pop());
            }
        }
    }
}
