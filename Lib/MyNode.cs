using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class MyNode<T>
    {
        public T Data = default(T);
        public MyNode<T> Next = null;
    }
}
