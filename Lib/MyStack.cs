using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class MyStack<T> : MyLinkedList<T>
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
        public void Push(T data)
        {
            AddBegining(data);
        }

        public T Peek()
        {
            if (Tail == null)
                throw new NullReferenceException("Stack is empty");

            return Tail.Data;
        }

        // remove and display the last pushed item
        public T Pop()
        {
            return DeleteLast();
        }
    }
}
