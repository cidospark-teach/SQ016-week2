using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class SimpleLinkedList<T> : MyLinkedList<T>
    {
        // add item at the end of the linkedList
        public void AddLast(T data)
        {
            AddEnd(data);
        }


        // add item at the begining of the linkedList
        public void AddFirst(T data)
        {
            AddBegining(data);
        }

        public void Remove(T data)
        {
            Delete(data);
        }
    }
}
