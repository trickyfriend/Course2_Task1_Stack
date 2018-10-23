using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyStack
    {
        MyNode head;
        int count;

        public MyNode Head
        {
            get { return head; }
            set { head = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Push(string str)
        {
            MyNode p = new MyNode(str, Head);
            Head = p;
            Count++;
        }

        public bool StackIsEmpty()
        {
            return Head == null;
        }

        public string Pop()
        {
            if (!StackIsEmpty())
            {
                string str = Head.Str;
                Head = Head.Next;
                Count--;
                return str;
            }
            else
                throw new Exception("Stack is empty!");
        }

        public MyStack()
        {
            this.Head = null;
            this.Count = 0;
        }
    }
}
