using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Generics
{
    public class LinkedListNode
    {
        public LinkedListNode(object value)
        {
            this.value = value;
        }

        private object value;
        public object Value
        {
            get { return value; }
        }

        private LinkedListNode next;
        public LinkedListNode Next
        {
            get { return next; }
            set { next = value; }
        }

        private LinkedListNode prev;
        public LinkedListNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }


	
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            this.value = value;
        }

        private T value;
        public T Value
        {
            get { return value; }
        }

        private LinkedListNode<T> next;
        public LinkedListNode<T> Next
        {
            get { return next; }
            internal set { next = value; }
        }

        private LinkedListNode<T> prev;
        public LinkedListNode<T> Prev
        {
            get { return prev; }
            internal set { prev = value; }
        }



    }
}
