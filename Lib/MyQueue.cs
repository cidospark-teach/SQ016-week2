using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class MyQueue<T> : MyLinkedList<T>
    {
        public int Size
        {
            get { return ListSize; }
        }

        public bool IsEmpty
        {
            get
            {
                return Empty;
            }
        } 

        // add item at the end of the stack
        public void Enqueue(T data)
        {
            AddEnd(data);
        }

        // remove and display the first enqueued item
        public T Dequeue()
        {
            return DeleteLast();
        }
    }
}
