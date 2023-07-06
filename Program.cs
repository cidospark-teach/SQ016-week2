using DataStructuresTask.Lib;
using DataStructuresTask.Lib.Commons;
using System;

namespace DataStructuresTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //MyStack<int> stack = new MyStack<int>();
            //stack.Push(2);
            //stack.Push(5);
            //stack.Push(7);

            //MyQueue<int> queue = new MyQueue<int>();

            SimpleLinkedList<int> list = new SimpleLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            list.PrintList();
           
        }

    }

}
