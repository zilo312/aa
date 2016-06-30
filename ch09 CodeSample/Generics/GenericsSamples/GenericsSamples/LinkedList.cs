using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Wrox.ProCSharp.Generics
{
    public class LinkedList : IEnumerable
    {
        private LinkedListNode first;

        public LinkedListNode First
        {
            get { return first; }
        }

        private LinkedListNode last;

        public LinkedListNode Last
        {
            get { return last; }
        }

        public LinkedListNode AddLast(object node)
        {
            LinkedListNode newNode = new LinkedListNode(node);
            if (first == null)
            {
                first = newNode;
                last = first;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            return newNode;
        }


        #region IEnumerable Members

        
        public IEnumerator GetEnumerator()
        {
            LinkedListNode current = first;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }            
        }

        #endregion
    }


    public class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> first;

        public LinkedListNode<T> First
        {
            get { return first; }
        }

        private LinkedListNode<T> last;

        public LinkedListNode<T> Last
        {
            get { return last; }
        }

        public LinkedListNode<T> AddLast(T node)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(node);
            if (first == null)
            {
                first = newNode;
                last = first;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            return newNode;
        }



        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = first;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }      
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            
        }

        #endregion
    }
}
