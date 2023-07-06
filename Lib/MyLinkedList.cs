using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public abstract class MyLinkedList<T>
    {
        protected MyNode<T> Head = null;
        protected MyNode<T> Tail = null;
        private int counter = 0;
        private int _size = 0;
        protected int ListSize { 
            get {
                if (Head == null)
                    return 0;

                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    _size++;
                }
                return _size;
            } 
        }

        protected bool Empty
        {
            get { 
                if(Head == null)
                {
                    return true;
                }
                return false;
            }
        }

        // add item at the end of the linkedList
        protected void AddEnd(T data)
        {
            MyNode<T> newItem = new MyNode<T>(); // make newItem a node
            newItem.Data = data;

            if (Head == null)
            {
                Head = newItem;

                Tail = Head;  // keeping track of last entry
            }
            else
            {
                Tail.Next = newItem;
                Tail = newItem; // keeping track of last entry
            }
        }

        // add item at the begining of the linkedList
        public void AddBegining(T data)
        {
            MyNode<T> newItem = new MyNode<T>(); // make newItem a node
            newItem.Data = data;

            newItem.Next = Head;
            Head = newItem;
            Tail = Head;
        }


        // check for an item
        public bool CheckFor(T data)
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            if (data.Equals(Head.Data))
                return true;

            while(Head.Next != null)
            {
                Head = Head.Next;
                counter += 1;
                if (data.Equals(Head.Data))
                    return true;
                
            }

            return false;

        }


        // get index
        public int IndexOfData(T data)
        {
            if(!CheckFor(data))
                return -1;

            return counter;
        }


        // print items from the linkedlist
        public virtual void PrintList()
        {
            var current = Head;
            if(current == null)
                throw new NullReferenceException("This data structure is empty");

            {
                while (current.Next != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }

                Console.WriteLine(current.Data);
            }

        }

        // remove item from list 
        protected void Delete(T data)
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            var current = Head;
            MyNode<T> prev = null;

            if (data.Equals(Head.Data))
            {
                while (current.Next != null)
                {
                    Head = current.Next;
                    return;
                }
            }

            while (current.Next != null && !data.Equals(current.Data))
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = current.Next;
        }

        protected T DeleteLast()
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            var current = Head;
            T temp = Head.Data;

            Head = current.Next;
            Tail = current.Next;
            return temp;

        }

    }
}
